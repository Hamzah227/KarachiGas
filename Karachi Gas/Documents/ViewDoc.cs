using Karachi_Gas.Classes;
using Karachi_Gas.Reports;
using System;
using System.Collections.Generic;

namespace Karachi_Gas.Documents
{
    public partial class ViewDoc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewDoc()
        {
            InitializeComponent();
        }
        public static DateTime from; public static DateTime to;
        public List<InvoiceDetail> list;
        public bool isInvoice = false, isMoneyTrail = false, isAccStatement = false, isSaleDetails = false, isSupplyDetails = false;
        //GenerateInvoice obj = new GenerateInvoice();
        private void documentViewer1_Load(object sender, EventArgs e)
        {
        }

       
        public void PrintInvoice(List<InvoiceDetail> data)
        {
            NewInvoice report = new NewInvoice();
            report.InnitData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void PrintCustomerSummary(List<Models.AccountSummary> data)
        {
            CustomerSummary report = new CustomerSummary();
            report.LoadData(data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        private void printPreviewBarItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        public void printNewCustomerLedger(List<Models.NewCustomerLedger> list)
        {
            Reports.CustomerLedgerReport report = new CustomerLedgerReport();
            report.innitData(list, from, to);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void printSaleDetails(List<Models.SaleDetails> list)
        {
            Reports.SaleDetailsReport report = new SaleDetailsReport();
            report.innitData(list, from, to);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        public void printPurchaseLedger(List<Models.PurchaseLedgerDetails> list)
        {
            Reports.PurchaseLedgerReport report = new PurchaseLedgerReport();
            report.innitData(list, from, to);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}