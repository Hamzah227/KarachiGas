using System;
using System.Collections.Generic;

namespace Karachi_Gas.Models
{
    public class NewLedgerModel : List<NewLedgerModel>
    {
        public string Party { get; set; }
        public string Company { get; set; }
        public Int64 QtyCom { get; set; }
        public Int64 QtyDom { get; set; }
        public Int64 QtySmall { get; set; }
        public Int64 RateCom { get; set; }
        public Int64 RateDom { get; set; }
        public Int64 RateSmall { get; set; }
        public Int64 BalCom { get; set; }
        public Int64 BalDom { get; set; }
        public Int64 BalSmall { get; set; }
        public Int64 PrevCom { get; set; }
        public Int64 PrevDom { get; set; }
        public Int64 PrevSmall { get; set; }
        public Int64 EmptyRecCom { get; set; }
        public Int64 EmptyRecDom { get; set; }
        public Int64 EmptyRecSmall { get; set; }
        public Int64 PrevCylBalance { get; set; }
        public Int64 CurrCylBalance { get; set; }
        public decimal Amount { get; set; }
        public decimal Receive { get; set; }
        public decimal PrevBalance { get; set; }
        public decimal Balance { get; set; }
        public DateTime Date { get; set; }
        public bool isEmpty { get; set; }

    }
}
