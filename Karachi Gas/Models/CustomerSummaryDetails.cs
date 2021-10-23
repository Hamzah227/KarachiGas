using System;
using System.Collections.Generic;

namespace Karachi_Gas.Models
{
    public class CustomerSummaryDetails : List<CustomerSummaryDetails>
    {
        public int AccID { get; set; }
        public string Title { get; set; }
        public int QtyC { get; set; }
        public int QtyD { get; set; }
        public int QtyS { get; set; }
        public bool isEmpty { get; set; }
        public DateTime DTStamp { get; set; }
        public long Balance { get; set; }
        public int CompID { get; set; }
        public string CompanyName { get; set; }
    }
}
