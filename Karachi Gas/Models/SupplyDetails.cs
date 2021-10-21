using System;
using System.Collections.Generic;

namespace Karachi_Gas.Models
{
    public class SupplyDetails : List<SupplyDetails>
    {
        public string Company { get; set; }
        public string Party { get; set; }
        public int QtyCom { get; set; }
        public int QtyDom { get; set; }
        public int QtySmall { get; set; }
        public int TotalCylinder { get; set; }
        public int PrevTotalCylinder { get; set; }
        public int RecvCylinder { get; set; }
        public int CurrCylBalance { get; set; }
        public DateTime Date_ { get; set; }
        public bool isGivenOrReturned { get; set; }
    }
}
