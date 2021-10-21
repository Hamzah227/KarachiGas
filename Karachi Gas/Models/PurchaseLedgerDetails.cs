using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karachi_Gas.Models
{
    public class PurchaseLedgerDetails : List<PurchaseLedgerDetails>
    {
        public DateTime DTStamp { get; set; }
        public string Narration { get; set; }
        public Int64 QtyC { get; set; }
        public Int64 QtyD { get; set; }
        public Int64 QtyS { get; set; }
        public decimal RateC { get; set; }
        public decimal RateD { get; set; }
        public decimal RateS { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}
