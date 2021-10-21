using Karachi_Gas.Classes;
using Karachi_Gas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Karachi_Gas.Documents
{
    public partial class PurchaseLedger : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PurchaseLedger()
        {
            InitializeComponent();
        }

        Int64 compId;
        GetPurchaseLedger purchaseLedger = new GetPurchaseLedger();
        List<PurchaseLedgerDetails> list;
        DateTime from, to;

        private void PurchaseLedger_Load(object sender, EventArgs e)
        {
            Ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            PopulateLookUpEdits();
            LoadGrid();
            SetDate();

            from = dateFrom.DateTime;
            to = dateTo.DateTime;
        }

        void SetDate()
        {
            dateFrom.DateTime = DateTime.Now.Subtract(TimeSpan.FromDays(7));
            dateTo.DateTime = DateTime.Now;
        }
        void PopulateLookUpEdits()
        {
            DataTable dt = Classes.GetData.GetCompany(0);
            //dt.Merge(Classes.GetData.GetAccountsWRTAccType(3));
            lookUpAccountsPurchase.Properties.DataSource = dt;
            lookUpAccountsPurchase.Properties.DisplayMember = "CompanyName";
            lookUpAccountsPurchase.Properties.ValueMember = "CompID";
            lookUpAccountsPurchase.Properties.PopulateColumns();
            lookUpAccountsPurchase.Properties.Columns["CompID"].Visible = false;
            lookUpAccountsPurchase.Properties.Columns["AccCode"].Visible = false;
            lookUpAccountsPurchase.Properties.Columns["CompAddress"].Visible = false;
            lookUpAccountsPurchase.Properties.Columns["Phone"].Visible = false;
            lookUpAccountsPurchase.Properties.Columns["Fax"].Visible = false;
            lookUpAccountsPurchase.Properties.Columns["UserID"].Visible = false;
            lookUpAccountsPurchase.Properties.Columns["DTStamp"].Visible = false;
        }

        void LoadGrid()
        {
            //gridControl1.DataSource = purLedger.GetPurchaseLedger(accCode, dateFrom.DateTime.Date, dateTo.DateTime.Date);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewReport();

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            compId = (Int64)lookUpAccountsPurchase.EditValue;
            LoadGrid();
        }

        void ViewReport()
        {
            LoadData();
            ViewDoc.from = from; ViewDoc.to = to;
            ViewDoc doc = new ViewDoc();
            doc.printPurchaseLedger(list);
            doc.MdiParent = Karachi_Gas.frm_Main.ActiveForm;
            doc.Dock = DockStyle.Fill;
            doc.Show();
            doc.BringToFront();
        }

        private void dateFrom_EditValueChanged(object sender, EventArgs e)
        {
            from = dateFrom.DateTime;
            LoadData();
        }

        private void dateTo_EditValueChanged(object sender, EventArgs e)
        {
            to = dateTo.DateTime;
            LoadData();
        }

        void LoadData()
        {
            GetPurchaseLedger.from = this.from;
            GetPurchaseLedger.to = this.to;
            list = purchaseLedger.PrintPurchaseLedger(compId);
        }
    }
}