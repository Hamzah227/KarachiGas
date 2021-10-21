using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Karachi_Gas.Reports
{
    public partial class PurchaseLedgerReport : DevExpress.XtraReports.UI.XtraReport
    {
        public PurchaseLedgerReport()
        {
            InitializeComponent();
        }

        public void innitData(List<Models.PurchaseLedgerDetails> list, DateTime from, DateTime to)
        {
            xrTableCell19.Text = from.ToString("dd/MM/yyy");        
            xrTableCell20.Text = to.ToString("dd/MM/yyy");

            objectDataSource1.DataSource = list;
        }

    }
}
