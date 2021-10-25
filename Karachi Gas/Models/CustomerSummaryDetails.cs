using System;
using System.Collections.Generic;

namespace Karachi_Gas.Models
{
    public class CustomerSummaryDetails 
    {
        public int AccID { get; set; }
        public string Title { get; set; }
        public int QtyC { get; set; }
        public int QtyD { get; set; }
        public int QtyS { get; set; }
        public bool isEmpty { get; set; }
        public long Balance { get; set; }
        public DateTime DTStamp { get; set; }
    }
    public class AccountSummary
    {
        public Int64 PartyAccID { get; set; }
        public Int64 CompAccID { get; set; }
        public string PartyTitle { get; set; }
        public string CompTitle { get; set; }
        public Int64 QtyC { get; set; }
        public Int64 QtyD { get; set; }
        public Int64 QtyS { get; set; }
        public string Type_ { get; set; }
        public long CompBalance { get; set; }
        public long PartyBalance { get; set; }
        public DateTime DTStamp { get; set; }
    }
}
