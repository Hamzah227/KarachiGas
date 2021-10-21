using Karachi_Gas.Classes;
using Karachi_Gas.Models;
using System;
using System.Collections.Generic;

namespace Karachi_Gas
{
    abstract class AbstractMembers
    {
        public virtual void InsertSql() { }
        public virtual void UpdateSql() { }
        public virtual void DeleteSql() { }
        public virtual void GetSql() { }
        public virtual void PrintReport(Int64 T) { }
        public virtual List<InvoiceDetail> PrintInvoice(Int64 id) { return new List<InvoiceDetail>(); }
        public virtual List<CustomerSummaryDetails> PrintCustomerSummary(Int64 id) { return new List<CustomerSummaryDetails>(); }
        public virtual List<NewCustomerLedger> PrintLedger(Int64 id) { return new List<NewCustomerLedger>(); }
        public virtual List<SaleDetails> PrintSaleDetails(Int64 id) { return new List<SaleDetails>(); }
        public virtual List<PurchaseLedgerDetails> PrintPurchaseLedger(Int64 id) { return new List<PurchaseLedgerDetails>(); }
        public virtual List<Models.GetCustSummarPartyWise> PrintCustomerSummaryPartyWise(Int64 partyId) { return new List<Models.GetCustSummarPartyWise>(); }
    }
}
