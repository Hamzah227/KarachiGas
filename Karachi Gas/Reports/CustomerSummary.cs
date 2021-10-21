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
        public void LoadData(List<CustomerSummaryDetails> data)
        {
            xrTable1.Visible = false;
            xrTable3.Visible = true;

            tblParty.Visible = false;
            tblCompany.Visible = true;
            if (GetCustomerSummary.allComp == true)
            {

                objectDataSource1.DataSource = data;
                xrTableCell16.Text = DateTime.Now.ToString("dd-MMM-yy h:mm:ss tt");
                xrTableCell1.Text = "Company: ALL";
                xrCellCompName.Visible = false;
            }
            else
            {

                objectDataSource1.DataSource = data;
                xrTableCell16.Text = DateTime.Now.ToString("dd-MMM-yy h:mm:ss tt");
                xrTableCell1.Text = "Company: ";
                xrCellCompName.Visible = true;
            }

        }

        public void LoadDataPartyWise(List<Models.GetCustSummarPartyWise> data, string from, string to)
        {
            xrFrom.Text = from;
            xrTo.Text = to;

            xrTable1.Visible = true;
            xrTable3.Visible = false;

            tblParty.Visible = true;
            tblCompany.Visible = false;
            xrTableCell4.Text = "Company";
            xrTableCell3.Text = "Comp ID";

            objectDataSource1.DataSource = data;
            xrTableCell16.Text = DateTime.Now.ToString("dd-MMM-yy h:mm:ss tt");
            xrCellCompName.Visible = false;
        }
    }
}
