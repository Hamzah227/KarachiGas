using Karachi_Gas.Documents;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Karachi_Gas.Reports
{
    public partial class GetCustomerSummary : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string from = string.Empty;
        string to = string.Empty;
        public GetCustomerSummary()
        {
            InitializeComponent();
        }

        public static DataTable dt = new DataTable();
        public static bool allComp = false;
        Int64 compId, partyId;
        Classes.GetCustomerSummary getCustomerSummary;
        Classes.GetCustomerSummaryPartyWise getCustomerSummaryPartyWise;

        private void GetCustomerSummary_Load(object sender, EventArgs e)
        {
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            PopulateLookupEdits();
            dtFrom.DateTime = DateTime.Now.Subtract(TimeSpan.FromDays(7));
            dtTo.DateTime = DateTime.Now;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (partyAll.Checked && compId != 0)
            {
                getCustomerSummary = new Classes.GetCustomerSummary();
                ViewSummaryForAllParty();
            }
            else if (compAll.Checked && partyId != 0)
            {
                getCustomerSummaryPartyWise = new Classes.GetCustomerSummaryPartyWise();
                ViewSummaryForAllCompany();
            }
            else if (partyAll.Checked && compAll.Checked)
            {
                ViewSummaryForAllCompanyAndParty();
            }
        }

        void PopulateLookupEdits()
        {
            lookUpCompany.Properties.DataSource = Classes.GetData.GetCompany(0);
            lookUpCompany.Properties.DisplayMember = "Name";
            lookUpCompany.Properties.ValueMember = "AccID";
            lookUpCompany.Properties.PopulateColumns();
            lookUpCompany.Properties.Columns["AccID"].Visible = false;
            lookUpCompany.Properties.Columns["ID"].Visible = false;
            lookUpCompany.Properties.Columns["Address_"].Visible = false;
            lookUpCompany.Properties.Columns["Phone"].Visible = false;
            lookUpCompany.Properties.Columns["Fax"].Visible = false;
            lookUpCompany.Properties.Columns["DTStamp"].Visible = false;

            lookUpEdit1.Properties.DataSource = Classes.GetData.GetParty(0);
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.ValueMember = "AccID";
            lookUpEdit1.Properties.PopulateColumns();
            lookUpEdit1.Properties.Columns["AccID"].Visible = false;
            lookUpEdit1.Properties.Columns["ID"].Visible = false;
            lookUpEdit1.Properties.Columns["Address_"].Visible = false;
            lookUpEdit1.Properties.Columns["Phone"].Visible = false;
            lookUpEdit1.Properties.Columns["Mobile"].Visible = false;
            lookUpEdit1.Properties.Columns["Cnic"].Visible = false;
            lookUpEdit1.Properties.Columns["Ntn"].Visible = false;
            lookUpEdit1.Properties.Columns["DTStamp"].Visible = false;
        }

        void ViewSummaryForAllParty()
        {
            from = dtFrom.EditValue.ToString();
            to = dtTo.EditValue.ToString();
            if (!emptyDetails.Checked)
            {
                List<Models.AccountSummary> list;
                if (compAll.Checked)
                {
                    list = getCustomerSummary.PrintCustomerSummary(0);
                }
                else
                {
                    list = getCustomerSummary.PrintCustomerSummary(this.compId);
                }

                ViewDoc frmDoc = null;
                if (frmDoc == null || frmDoc.Text == "")
                {
                    frmDoc = new ViewDoc();
                    frmDoc.MdiParent = Karachi_Gas.frm_Main.ActiveForm;
                    frmDoc.Dock = DockStyle.Fill;
                    frmDoc.PrintCustomerSummary(list);
                    frmDoc.Show();
                    frmDoc.BringToFront();
                }
            }
            else if (emptyDetails.Checked)
            {
                List<Models.GetCustSummarPartyWise> list;
                if (partyAll.Checked)
                {
                    list = getCustomerSummaryPartyWise.PrintCustomerSummaryPartyWise(0);
                }
                else
                {
                    list = getCustomerSummaryPartyWise.PrintCustomerSummaryPartyWise(partyId);
                }

                ViewDoc frmDoc = null;
                if (frmDoc == null || frmDoc.Text == "")
                {
                    frmDoc = new ViewDoc();
                    frmDoc.MdiParent = Karachi_Gas.frm_Main.ActiveForm;
                    frmDoc.Dock = DockStyle.Fill;
                    //frmDoc.printCustomerSummaryPartyWise(list, from, to);
                    frmDoc.Show();
                    frmDoc.BringToFront();
                }
            }
        }
        void ViewSummaryForAllCompany()
        {
            from = dtFrom.EditValue.ToString();
            to = dtTo.EditValue.ToString();
            if (!emptyDetails.Checked)
            {
                List<Models.AccountSummary> list;
                list = getCustomerSummaryPartyWise.PrintCustomerSummary(this.partyId);

                ViewDoc frmDoc = null;
                if (frmDoc == null || frmDoc.Text == "")
                {
                    frmDoc = new ViewDoc();
                    frmDoc.MdiParent = Karachi_Gas.frm_Main.ActiveForm;
                    frmDoc.Dock = DockStyle.Fill;
                    frmDoc.PrintCustomerSummaryPartyWise(list);
                    frmDoc.Show();
                    frmDoc.BringToFront();
                }
            }
            else if (emptyDetails.Checked)
            {
                List<Models.GetCustSummarPartyWise> list;
                if (partyAll.Checked)
                {
                    list = getCustomerSummaryPartyWise.PrintCustomerSummaryPartyWise(0);
                }
                else
                {
                    list = getCustomerSummaryPartyWise.PrintCustomerSummaryPartyWise(partyId);
                }

                ViewDoc frmDoc = null;
                if (frmDoc == null || frmDoc.Text == "")
                {
                    frmDoc = new ViewDoc();
                    frmDoc.MdiParent = Karachi_Gas.frm_Main.ActiveForm;
                    frmDoc.Dock = DockStyle.Fill;
                    //frmDoc.printCustomerSummaryPartyWise(list, from, to);
                    frmDoc.Show();
                    frmDoc.BringToFront();
                }
            }
        }
        void ViewSummaryForAllCompanyAndParty()
        {
        }
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void groupControlCompany_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkEditAllParty_CheckedChanged_1(object sender, EventArgs e)
        {
            if (compAll.Checked)
            {
                lookUpCompany.Enabled = false;
            }
            else
            {
                lookUpCompany.Enabled = true;
            }
        }

        private void lookUpCompany_EditValueChanged(object sender, EventArgs e)
        {
            compId = (Int64)lookUpCompany.EditValue;
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEdit1.EditValue != null)
            {
                partyId = (Int64)lookUpEdit1.EditValue;
            }
        }


    }
}