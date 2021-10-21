using System;
using System.Collections.Generic;

namespace Karachi_Gas.Models
{
    public class TransactionDetails : List<TransactionDetails>
    {
        public int TransactionID { get; set; }
        public int SaleID { get; set; }
        public string AccTitle { get; set; }
        public long SaleAmount { get; set; }
        public long Receive { get; set; }
        public long Balance { get; set; }
        public DateTime TransactionDate { get; set; }
        public long AccBalance { get; set; }

    }
}
