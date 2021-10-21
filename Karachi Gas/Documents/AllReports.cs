using DevExpress.XtraEditors;
using Karachi_Gas.Classes;
using Karachi_Gas.Documents;
using Karachi_Gas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Karachi_Gas.Reports
{
    public partial class AllReports : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AllReports()
        {
            InitializeComponent();
        }

        GetLedger getLedger = new GetLedger();
        public DataTable dt; public static string to = string.Empty, from = string.Empty; int pId; bool isCompanyDetails = false;

        private void AllReports_Load(object sender, EventArgs e)
        {
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            Reset();
        }

        void populateLookupEdits()
        {
            try
            {
                DataTable dt = Classes.GetData.GetAccountsWRTAccType(1);
                lookUpEditParty.Properties.DataSource = dt;
                lookUpEditParty.Properties.DisplayMember = "AccTitle";
                lookUpEditParty.Properties.ValueMember = "AccountCode";
                lookUpEditParty.Properties.PopulateColumns();
                lookUpEditParty.Properties.Columns["AccOpening"].Visible = false;
                lookUpEditParty.Properties.Columns["AccType"].Visible = false;
                lookUpEditParty.Properties.Columns["AccCategory"].Visible = false;
                lookUpEditParty.Properties.Columns["UserID"].Visible = false;
                lookUpEditParty.Properties.Columns["DTStamp"].Visible = false;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "Error Occurred Fetching Accounts..");
            }
        }

        void Reset()
        {
            populateLookupEdits();
            dtFrom.DateTime = DateTime.Now.Date;
            dtTo.DateTime = DateTime.Now.AddDays(7).Date;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewDoc.from = dtFrom.DateTime;
            ViewDoc.to = dtTo.DateTime;

            GetLedger.from = dtFrom.DateTime;
            GetLedger.to = dtTo.DateTime;

            if (!isCompanyDetails)
            {
                ViewDoc doc = new ViewDoc();
                doc.printNewCustomerLedger(CalculateEachDate());
                doc.MdiParent = Karachi_Gas.frm_Main.ActiveForm;
                doc.Dock = DockStyle.Fill;
                doc.Show();
                doc.BringToFront();
            }
            else
            {
                
            }
        }

        List<NewCustomerLedger> CalculateEachDate()
        {
            bool isFound = false; bool isPQtyFound = false; bool currBalanceFound = false;
            int partyId = pId;
            string partyName = string.Empty;
            string compAccTitle = string.Empty;
            decimal prevBalance = 0;
            decimal currBalance = 0;
            Int64 compAcc = 0;
            Int64 sQtyCom = 0;
            Int64 sQtyDom = 0;
            Int64 sQtySmall = 0;
            Int64 rQtyCom = 0;
            Int64 rQtyDom = 0;
            Int64 rQtySmall = 0;
            Int64 pQtyCom = 0;
            Int64 pQtyDom = 0;
            Int64 pQtySmall = 0;
            Int64 cQtyCom = 0;
            Int64 cQtyDom = 0;
            Int64 cQtySmall = 0;
            decimal saleAmount = 0;
            decimal recAmount = 0;
            List<NewCustomerLedger> ledger = new List<NewCustomerLedger>();
            try
            {
                List<NewCustomerLedger> list = getLedger.PrintLedger(pId);
                IEnumerable<string> distinctDates = list.Select(x => DataHelper.dateOnly(x.DTStamp)).Distinct().ToList();
                foreach (string date in distinctDates)
                {
                    foreach (NewCustomerLedger item in list)
                    {
                        if (DataHelper.dateOnly(item.DTStamp) == date)
                        {
                            sQtyCom += item.QtyC;
                            sQtyDom += item.QtyD;
                            sQtySmall += item.QtyS;

                            rQtyCom += item.RecC;
                            rQtyDom += item.RecD;
                            rQtySmall += item.RecS;

                            if (!isPQtyFound)
                            {
                                pQtyCom = item.PrevC;
                                pQtyDom = item.PrevD;
                                pQtySmall = item.PrevS;
                            }
                            if (pQtyCom != 0)
                            {
                                isPQtyFound = true;
                            }

                            if (item.TranType != "TRANSFER")
                            {
                                cQtyCom = item.BalC;
                                cQtyDom = item.BalD;
                                cQtySmall = item.BalS;
                            }
                            saleAmount += item.TotalAmount;
                            if (!isFound)
                            {
                                prevBalance = item.PrevBalance;
                            }
                            if (prevBalance != 0)
                            {
                                isFound = true;

                            }
                            recAmount += item.RecAmount;
                            if (item.TranType != "EMPTY")
                            {
                                currBalance = item.CurrentBalance;
                            }
                            compAcc = item.CompAcc;
                            partyName = item.PartyName;
                        }
                    }
                    ledger.Add(new NewCustomerLedger
                    {
                        QtyC = sQtyCom,
                        QtyD = sQtyDom,
                        QtyS = sQtySmall,

                        RecC = rQtyCom,
                        RecD = rQtyDom,
                        RecS = rQtySmall,

                        PrevC = pQtyCom,
                        PrevD = pQtyDom,
                        PrevS = pQtySmall,

                        BalC = cQtyCom,
                        BalD = cQtyDom,
                        BalS = cQtySmall,

                        TotalAmount = saleAmount,

                        PrevBalance = prevBalance,
                        RecAmount = recAmount,
                        CurrentBalance = currBalance,

                        DTStamp = Convert.ToDateTime(date),
                        CompAcc = compAcc,

                        PartyName = partyName,
                    });
                }
                return ledger;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            
        }

        private void lookUpEditParty_EditValueChanged(object sender, EventArgs e)
        {
            pId = DataHelper.intParse(lookUpEditParty.EditValue);
        }

        private void dtFrom_EditValueChanged(object sender, EventArgs e)
        {
            from = DataHelper.dateOnly(dtFrom.EditValue);
        }

        private void dtTo_EditValueChanged(object sender, EventArgs e)
        {
            to = DataHelper.dateOnly(dtTo.EditValue);
        }

        private void chkAllComp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllComp.Checked)
            {
                //lookUpEditComp.Enabled = true;
                isCompanyDetails = true;
            }
            else
            {
                //lookUpEditComp.Enabled = false;
                isCompanyDetails = false;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
    }


}