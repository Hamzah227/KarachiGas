using System;
using System.Collections.Generic;

namespace Karachi_Gas.Reports
{
    public partial class CustomerSummaryPartyWise : DevExpress.XtraReports.UI.XtraReport
    {
        public CustomerSummaryPartyWise()
        {
            InitializeComponent();
        }

        public void LoadData(List<Models.AccountSummary> data)
        {
            //xrCellDate.Text = DateTime.Now.ToString("dd-MMM-yy h:mm:ss tt");
            objectDataSource2.DataSource = data;
        }

    }
}
