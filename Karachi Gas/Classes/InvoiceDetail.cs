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
        public string PartyId { get; set; }
        public string PartyName { get; set; }
        public string PartyAddress { get; set; }
        public string NTN_No { get; set; }
        public string CNIC_No { get; set; }
        public string PartyMobile { get; set; }
    }
}
