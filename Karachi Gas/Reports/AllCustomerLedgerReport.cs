using System;
using System.Collections.Generic;
using System.Globalization;

namespace Karachi_Gas.Reports
{
    public partial class AllCustomerLedgerReport : DevExpress.XtraReports.UI.XtraReport
    {
        public AllCustomerLedgerReport()
        {
            InitializeComponent();
            MainReport();
        }

        public void innitData(List<Models.NewCustomerLedger> list, DateTime from, DateTime to)
        {
            objectDataSource2.DataSource = list;
            xrTableCell24.Text = from.ToString("dd-MMM-yyyy");
            xrTableCell26.Text = to.ToString("dd-MMM-yyyy");
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
