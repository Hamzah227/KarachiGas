using Karachi_Gas.Documents;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Karachi_Gas.Reports
{
    public partial class GetCustomerSummary : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GetCustomerSummary()
        {
            InitializeComponent();
        }

        public static DataTable dt = new DataTable();
        public static bool allComp = false;
        Int64 compId, partyId;
        Classes.GetCustomerSummary getCustomerSummary = new Classes.GetCustomerSummary();
        Classes.GetCustomerSummaryPartyWise getCustomerSummaryPartyWise = new Classes.GetCustomerSummaryPartyWise();

        private void GetCustomerSummary_Load(object sender, EventArgs e)
        {
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            PopulateLookupEdits();
            dtFrom.DateTime = DateTime.Now.Subtract(TimeSpan.FromDays(7));
            dtTo.DateTime = DateTime.Now;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewSummary();
        }

        void PopulateLookupEdits()
        {
            lookUpCompany.Properties.DataSource = Classes.GetData.GetCompany(0);
            lookUpCompany.Properties.DisplayMember = "CompanyName";
            lookUpCompany.Properties.ValueMember = "CompID";
            lookUpCompany.Properties.PopulateColumns();
            lookUpCompany.Properties.Columns["AccCode"].Visible = false;
            lookUpCompany.Properties.Columns["CompID"].Visible = false;
            lookUpCompany.Properties.Columns["CompAddress"].Visible = false;
            lookUpCompany.Properties.Columns["Phone"].Visible = false;
            lookUpCompany.Properties.Columns["Fax"].Visible = false;
            lookUpCompany.Properties.Columns["UserID"].Visible = false;
            lookUpCompany.Properties.Columns["DTStamp"].Visible = false;

            lookUpEdit1.Properties.DataSource = Classes.GetData.GetParty(0);
            lookUpEdit1.Properties.DisplayMember = "PartyName";
            lookUpEdit1.Properties.ValueMember = "PartyID";
            lookUpEdit1.Properties.PopulateColumns();
            lookUpEdit1.Properties.Columns["AccCode"].Visible = false;
            lookUpEdit1.Properties.Columns["PartyID"].Visible = false;
            lookUpEdit1.Properties.Columns["PartyAddress"].Visible = false;
            lookUpEdit1.Properties.Columns["PartyPhone"].Visible = false;
            lookUpEdit1.Properties.Columns["PartyMobile"].Visible = false;
            lookUpEdit1.Properties.Columns["CNIC_No"].Visible = false;
            lookUpEdit1.Properties.Columns["NTN_No"].Visible = false;
            lookUpEdit1.Properties.Columns["UserID"].Visible = false;
            lookUpEdit1.Properties.Columns["DTStamp"].Visible = false;
        }

        void ViewSummary()
        {
            string from = dtFrom.EditValue.ToString();
            string to = dtTo.EditValue.ToString();
            if (!chkForParty.Checked)
            {
                List<Models.CustomerSummaryDetails> list;
                if (chkEditAllComp.Checked)
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
            else if (chkForParty.Checked)
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
                    frmDoc.printCustomerSummaryPartyWise(list, from, to);
                    frmDoc.Show();
                    frmDoc.BringToFront();
                }
            }
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
            if (chkEditAllComp.Checked)
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