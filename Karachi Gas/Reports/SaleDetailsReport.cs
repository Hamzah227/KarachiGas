using System;
using System.Collections.Generic;


namespace Karachi_Gas.Reports
{
    public partial class SaleDetailsReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SaleDetailsReport()
        {
            InitializeComponent();
        }

        public static bool isCompAll = false, isPartyAll = false;

        private void SaleDetailsReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        public void innitData(List<Models.SaleDetails> list, DateTime from, DateTime to)
        {
            if (isCompAll)
            {
                compTable.Visible = false;
                allCompTable.Visible = true;
            }
            else
            {
                compTable.Visible = true;
                allCompTable.Visible = false;
            }
            if (isPartyAll)
            {
                partyTable.Visible = false;
                allPartyTable.Visible = true;
                
            }

            objectDataSource1.DataSource = list;
            xrTableCell16.Text = from.ToString("dd/MM/yyy");
            xrTableCell18.Text = to.ToString("dd/MM/yyy");
        }

    }
}
