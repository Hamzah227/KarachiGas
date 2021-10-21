using System;
using System.Collections.Generic;

namespace Karachi_Gas.Models
{
    public class GetCustSummarPartyWise : List<GetCustSummarPartyWise>
    {
        public int PartyID { get; set; }
        public string PartyName { get; set; }
        public string CompanyName { get; set; }
        public int QtyC { get; set; }
        public int QtyD { get; set; }
        public int QtyS { get; set; }
        public long Balance { get; set; }
    }
}
