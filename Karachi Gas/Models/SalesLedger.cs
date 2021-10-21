using System;
using System.Collections.Generic;

namespace Karachi_Gas.Models
{
    public class SalesLedger : List<SalesLedger>
    {
        public string AccTitle { get; set; }
        public int QtyCom { get; set; }
        public double RateCom { get; set; }
        public int QtyDom { get; set; }
        public double RateDom { get; set; }
        public int QtySmall { get; set; }
        public double RateSmall { get; set; }
        public double Credit { get; set; }
        public double Debit { get; set; }
        public double PrevBalance { get; set; }
        public double CurrentBalance { get; set; }
        public DateTime Date_ { get; set; }
    }
}
