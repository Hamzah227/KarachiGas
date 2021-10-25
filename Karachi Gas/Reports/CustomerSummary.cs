using Karachi_Gas.Models;
using System;
using System.Collections.Generic;

namespace Karachi_Gas.Reports
{
    public partial class CustomerSummary : DevExpress.XtraReports.UI.XtraReport
    {
        public CustomerSummary()
        {
            InitializeComponent();
        }

        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
        public void LoadData(List<AccountSummary> data)
        {
            objectDataSource2.DataSource = data;
            xrTableCell16.Text = DateTime.Now.ToString("dd-MMM-yy h:mm:ss tt");
        }
    }
}
