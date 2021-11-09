using DevExpress.XtraEditors;
using Karachi_Gas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Karachi_Gas.Classes
{
    class GetInvoice : AbstractMembers
    {
        DataTable dt;
        public override List<InvoiceDetail> PrintInvoice(Int64 id)
        {
            List<InvoiceDetail> list;
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetInvoiceBySaleID " + id + "");
                if (!response.Error)
                {
                    list = dt.ToList<InvoiceDetail>();
                    return list;
                    //PrintInvoice(list);
                }
                return null;
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show("INVOICE", ae.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }

    class GetLedger : AbstractMembers
    {
        DataTable dt;
        public static DateTime from;
        public static DateTime to;
        public override List<NewCustomerLedger> PrintLedger(Int64 partyId)
        {
            List<NewCustomerLedger> list;
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetCustomerLedger " + partyId + ",'" + from + "','" + to + "'");
                if (!response.Error)
                {
                    list = dt.ToList<NewCustomerLedger>();
                    return list;
                }
                return null;
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show("Customer Ledger", ae.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }

    class GetCustomerSummary : AbstractMembers
    {
        List<AccountSummary> accountSummary;
        Int64 totalC;
        Int64 totalD;
        Int64 totalS;

        Int64 totalC_E;
        Int64 totalD_E;
        Int64 totalS_E;

        Int64 remC;
        Int64 remD;
        Int64 remS;
        DataTable dt;
        DataTable dtNew;
        List<AccountSummary> list;
        public override List<AccountSummary> PrintCustomerSummary (Int64 compId)
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetAccountsSummary");
                dtNew = DBService.FetchTable("EXEC GetParty 0");
                if (!response.Error)
                {
                    list = dt.ToList<AccountSummary>();
                    Calculations();
                    return accountSummary;
                }
                return null;
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "CustomerSummary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        

        public void Calculations()
        {
            List<Int64> calculatedAccounts = new List<Int64>();
            try
            {
                accountSummary = new List<AccountSummary>();
                foreach (AccountSummary item in list)
                {
                    if (item.PartyAccID != 0 && !calculatedAccounts.Contains(item.PartyAccID))
                    {
                        string expression = "AccID = " + item.PartyAccID;
                        Sum(item.PartyAccID);
                        accountSummary.Add(new AccountSummary()
                        {
                            PartyAccID = item.PartyAccID,
                            PartyBalance = item.PartyBalance,
                            PartyTitle = dtNew.Select(expression)[0].Field<string>("Name"),
                            QtyC = remC,
                            QtyD = remD,
                            QtyS = remS
                        });
                    }
                    calculatedAccounts.Add(item.PartyAccID);
                }
            }
            catch (Exception e)
            { }
        }

        void Sum(Int64 AccId)
        {
            totalC = list.Where(x => x.Type_ == "SAL" && x.PartyAccID == AccId).Sum(x => x.QtyC);
            totalD = list.Where(x => x.Type_ == "SAL" && x.PartyAccID == AccId).Sum(x => x.QtyD);
            totalS = list.Where(x => x.Type_ == "SAL" && x.PartyAccID == AccId).Sum(x => x.QtyS);

            totalC_E = list.Where(x => x.Type_ == "EMP" && x.PartyAccID == AccId).Sum(x => x.QtyC);
            totalD_E = list.Where(x => x.Type_ == "EMP" && x.PartyAccID == AccId).Sum(x => x.QtyD);
            totalS_E = list.Where(x => x.Type_ == "EMP" && x.PartyAccID == AccId).Sum(x => x.QtyS);

            remC = totalC - totalC_E;
            remD = totalD - totalD_E;
            remS = totalS - totalS_E;
        }
    }
    class GetCustomerSummaryPartyWise : AbstractMembers
    {
        List<AccountSummary> accountSummary;
        Int64 totalC;
        Int64 totalD;
        Int64 totalS;

        Int64 totalC_E;
        Int64 totalD_E;
        Int64 totalS_E;

        Int64 remC;
        Int64 remD;
        Int64 remS;
        DataTable dt;
        DataTable dtNew;
        List<AccountSummary> list;
        public override List<AccountSummary> PrintCustomerSummary(Int64 partyId)
        {
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetAccountsSummary");
                dtNew = DBService.FetchTable("EXEC GetCompany 0");
                if (!response.Error)
                {
                    list = dt.ToList<AccountSummary>();
                    Calculations(partyId);
                    return accountSummary;
                }
                return null;
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "CustomerSummary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Calculations(Int64 partyId)
        {
            try
            {
                string expression = string.Empty;
                accountSummary = new List<AccountSummary>();
                List<DateTime> distinctDates = new List<DateTime>();
                distinctDates = list.Select(x => x.DTStamp.Date).Distinct().OrderByDescending(x => x.Date).Reverse().ToList();
                list = list.Where(x => x.PartyAccID == partyId).ToList();
                foreach (DateTime date in distinctDates)
                {
                    AccountSummary[] items = list.Where(x => x.DTStamp.Date == date).ToArray();
                    for (int i = 0; i < items.Length; i++)
                    {
                        expression = "AccID = " + (items[i].Type_ != "SAL" ? items[i].CompAccID.ToString() : "");
                        Sum(items[i].PartyAccID, date);
                    }
                    if (items.Length != 0)
                    {
                        accountSummary.Add(new AccountSummary()
                        {
                            PartyAccID = items[0].PartyAccID,
                            PartyBalance = items[0].PartyBalance,
                            CompTitle = expression.Any(char.IsDigit) ? dtNew.Select(expression)[0].Field<string>("Name") : "SALE",
                            CompAccID = items[0].CompAccID,
                            QtyC = remC,
                            QtyD = remD,
                            QtyS = remS,
                            DTStamp = date
                        });
                    }
                }
            }
            catch (Exception e)
            { }
        }

        void Sum(Int64 AccId, DateTime date)
        {
            totalC = list.Where(x => x.Type_ == "SAL" && x.PartyAccID == AccId && x.DTStamp.Date == date).Sum(x => x.QtyC);
            totalD = list.Where(x => x.Type_ == "SAL" && x.PartyAccID == AccId && x.DTStamp.Date == date).Sum(x => x.QtyD);
            totalS = list.Where(x => x.Type_ == "SAL" && x.PartyAccID == AccId && x.DTStamp.Date == date).Sum(x => x.QtyS);

            totalC_E = list.Where(x => x.Type_ == "EMP" && x.PartyAccID == AccId && x.DTStamp.Date == date).Sum(x => x.QtyC);
            totalD_E = list.Where(x => x.Type_ == "EMP" && x.PartyAccID == AccId && x.DTStamp.Date == date).Sum(x => x.QtyD);
            totalS_E = list.Where(x => x.Type_ == "EMP" && x.PartyAccID == AccId && x.DTStamp.Date == date).Sum(x => x.QtyS);
            
            remC = totalC - totalC_E;
            remD = totalD - totalD_E;
            remS = totalS - totalS_E;
        }
    }
    class GetSaleDetails : AbstractMembers
    {
        DataTable dt;
        Int64 compId = 0;
        public GetSaleDetails(Int64 id)
        {
            compId = id;
        }
 
        public override List<SaleDetails> PrintSaleDetails(Int64 partyId)
        {
            List<SaleDetails> list;
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetSales " + compId + "," + partyId);
                if (!response.Error)
                {
                    list = dt.ToList<SaleDetails>();
                    return list;
                }
                return null;
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "Sale Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }

    class GetPurchaseLedger : AbstractMembers
    {
        DataTable dt;
        public static DateTime from, to;
        public override List<PurchaseLedgerDetails> PrintPurchaseLedger(Int64 compId)
        {
            try
            {
                string frm = DataHelper.dateOnly(from);
                string too = DataHelper.dateOnly(to);
                List<PurchaseLedgerDetails> list;
                try
                {
                    ErrorResponse response = new ErrorResponse();
                    dt = DBService.FetchTable("EXEC GetPurhcaseLedger " + compId + ",'" + frm + "','" + too + "'");
                    if (!response.Error)
                    {
                        list = dt.ToList<PurchaseLedgerDetails>();
                        return list;
                    }
                    return null;
                }
                catch (Exception ae)
                {
                    XtraMessageBox.Show("Customer Ledger", ae.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
