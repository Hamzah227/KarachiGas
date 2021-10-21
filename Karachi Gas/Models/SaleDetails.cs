using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karachi_Gas.Models
{
    public class SaleDetails : List<SaleDetails>
    {
        public Int64 ID { get; set; }
        public Int64 TranID { get; set; }
        public Int64 CompID { get; set; }
        public string CompanyName { get; set; }
        public decimal RateC { get; set; }
        public decimal RateD { get; set; }
        public decimal RateS { get; set; }
        public DateTime DTStamp { get; set; }
        public string PartyName { get; set; }
        public Int64 QtyC { get; set; }
        public Int64 QtyD { get; set; }
        public Int64 QtyS { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalWithoutTax { get; set; }
        public decimal TaxPayable { get; set; }
        public decimal TotalWithTax { get; set; }

    }
}
