using Karachi_Gas.Classes;
using Karachi_Gas.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Karachi_Gas.Reports
{
    public partial class SaleDetails : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SaleDetails()
        {
            InitializeComponent();
        }

        GetSaleDetails getSaleDetails;
        DateTime from, to;
        Int64 compId, partyId;
        private void SaleDetails_Load(object sender, EventArgs e)
        {
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            FillLookupEdits();
            SetDate();
        }

        void FillLookupEdits()
        {
            lookCompany.Properties.DataSource = Classes.GetData.GetCompany(0);
            lookCompany.Properties.DisplayMember = "CompanyName";
            lookCompany.Properties.ValueMember = "CompID";
            lookCompany.Properties.PopulateColumns();
            lookCompany.Properties.Columns["AccCode"].Visible = false;
            lookCompany.Properties.Columns["CompID"].Visible = false;
            lookCompany.Properties.Columns["CompAddress"].Visible = false;
            lookCompany.Properties.Columns["Phone"].Visible = false;
            lookCompany.Properties.Columns["Fax"].Visible = false;
            lookCompany.Properties.Columns["UserID"].Visible = false;
            lookCompany.Properties.Columns["DTStamp"].Visible = false;

            lookParty.Properties.DataSource = Classes.GetData.GetParty(0);
            lookParty.Properties.DisplayMember = "PartyName";
            lookParty.Properties.ValueMember = "PartyID";
            lookParty.Properties.PopulateColumns();
            lookParty.Properties.Columns["PartyID"].Visible = false;
            lookParty.Properties.Columns["AccCode"].Visible = false;
            lookParty.Properties.Columns["PartyAddress"].Visible = false;
            lookParty.Properties.Columns["PartyPhone"].Visible = false;
            lookParty.Properties.Columns["PartyMobile"].Visible = false;
            lookParty.Properties.Columns["CNIC_No"].Visible = false;
            lookParty.Properties.Columns["NTN_No"].Visible = false;
            lookParty.Properties.Columns["UserID"].Visible = false;
            lookParty.Properties.Columns["DTStamp"].Visible = false;
        }

        void SetDate()
        {
            dtFrom.DateTime = DateTime.Now.Subtract(TimeSpan.FromDays(7));
            dtTo.DateTime = DateTime.Now;
        }
        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewSaleDetails();
        }

        void ViewSaleDetails()
        {

            if (chkCompAll.Checked)
            {
                SaleDetailsReport.isCompAll = true;
                getSaleDetails = new GetSaleDetails(0);
            }
            else
            {
                SaleDetailsReport.isCompAll = false;
                compId = (Int64)lookCompany.EditValue;
                getSaleDetails = new GetSaleDetails(compId);
            }


            if (chkPartyAll.Checked)
            {
                SaleDetailsReport.isPartyAll = true;
                partyId = 0;
            }
            else
            {
                SaleDetailsReport.isPartyAll = false;
                partyId = (Int64)lookParty.EditValue;
            }

            
            ViewDoc.from = from; ViewDoc.to = to;
            ViewDoc doc = new ViewDoc();
            doc.printSaleDetails(getSaleDetails.PrintSaleDetails(partyId));
            doc.MdiParent = Karachi_Gas.frm_Main.ActiveForm;
            doc.Dock = DockStyle.Fill;
            doc.Show();
            doc.BringToFront();
        }

        private void dtFrom_EditValueChanged(object sender, EventArgs e)
        {
            from = dtFrom.DateTime;
        }

        private void dtTo_EditValueChanged(object sender, EventArgs e)
        {
            to = dtTo.DateTime;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }
    }
}