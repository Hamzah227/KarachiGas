using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Karachi_Gas.Reports
{
    public partial class CustomerLedgerReport : DevExpress.XtraReports.UI.XtraReport
    {
        public CustomerLedgerReport()
        {
            InitializeComponent();
            MainReport();
        }

        public void innitData(List<Models.NewCustomerLedger> list, DateTime from, DateTime to)
        {
            objectDataSource1.DataSource = list;
            xrTableCell24.Text = from.ToString("dd/MMM/yyyy");
            xrTableCell26.Text = to.ToString("dd/MMM/yyyy");
        }

        private void CustomerLedgerReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        [STAThread]
        private void MainReport()
        {
            CultureInfo culture = new CultureInfo("en-US", true);
            culture.NumberFormat.CurrencySymbol = "";
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            DevExpress.Utils.FormatInfo.AlwaysUseThreadFormat = true;
        }
    }
}
