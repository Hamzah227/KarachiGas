namespace Karachi_Gas.Models
{
    public class NewAllCustomerLedger
    {
        public string AccTitle { get; set; }
        public int SupplyQtyCom { get; set; }
        public int SupplyQtyDom { get; set; }
        public int SupplyQtySmall { get; set; }
        public int RecQtyCom { get; set; }
        public int RecQtyDom { get; set; }
        public int RecQtySmall { get; set; }
        public decimal SaleAmount { get; set; }
        public decimal RecAmount { get; set; }
        public decimal PrevBalance { get; set; }
        public decimal CurrBalance { get; set; }
    }
}
