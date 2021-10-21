using System;

namespace Karachi_Gas.Models
{
    public class NewCustomerLedger
    {
        public Int64 TranID { get; set; }
        public string TranType { get; set; }
        public Int64 CompAcc { get; set; }
        public string PartyName { get; set; }
        public DateTime DTStamp { get; set; }
        public Int64 SaleId { get; set; }
        public Int64 QtyC { get; set; }
        public Int64 QtyD { get; set; }
        public Int64 QtyS { get; set; }
        public Int64 RecC { get; set; }
        public Int64 RecD { get; set; }
        public Int64 RecS { get; set; }
        public Int64 PrevC { get; set; }
        public Int64 PrevD { get; set; }
        public Int64 PrevS { get; set; }
        public Int64 BalC { get; set; }
        public Int64 BalD { get; set; }
        public Int64 BalS { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PrevBalance { get; set; }
        public decimal RecAmount { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}
