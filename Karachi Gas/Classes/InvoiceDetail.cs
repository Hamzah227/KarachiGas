using System;
using System.Collections.Generic;

namespace Karachi_Gas.Classes
{
    public class InvoiceDetail : List<InvoiceDetail>
    {
        public string InvoiceId { get; set; }
        public string RateC { get; set; }
        public string RateD { get; set; }
        public string RateS { get; set; }
        public DateTime DTStamp { get; set; }
        public string QtyC { get; set; }
        public string QtyD { get; set; }
        public string QtyS { get; set; }
        public string Discount { get; set; }
        public string TotalWithoutTax { get; set; }
        public string Tax { get; set; }
        public string TaxPayable { get; set; }
        public string TotalWithTax { get; set; }
        public string AccID { get; set; }
        public string Title { get; set; }
        public string Address_ { get; set; }
        public string Ntn { get; set; }
        public string Cnic { get; set; }
        public string Mobile { get; set; }
    }
}
