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
                dt = DBService.FetchTable("EXEC GetInvoiceThroughID " + id + "");
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
        DataTable dt;
        
        public override List<CustomerSummaryDetails> PrintCustomerSummary (Int64 compId)
        {
            List<CustomerSummaryDetails> list;
            try
            {
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetCustomerSummary " + compId + "," + 0);
                if (!response.Error)
                {
                    list = dt.ToList<CustomerSummaryDetails>();
                    return list;
                }
                return null;
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "CustomerSummary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
    class GetCustomerSummaryPartyWise : AbstractMembers
    {
        public static Int64 compId, partyId;
        public override List<Models.GetCustSummarPartyWise> PrintCustomerSummaryPartyWise(Int64 partyId) 
        {
            DataTable dt;
            try
            {
                List<Models.GetCustSummarPartyWise> list;
                ErrorResponse response = new ErrorResponse();
                dt = DBService.FetchTable("EXEC GetCustomerSummary " + 0 + "," + partyId);
                if (!response.Error)
                {
                    list = dt.ToList<Models.GetCustSummarPartyWise>();
                    return list;
                }
                return null;
            }
            catch (Exception ae)
            {
                XtraMessageBox.Show(ae.Message, "CustomerSummary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return null;
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
