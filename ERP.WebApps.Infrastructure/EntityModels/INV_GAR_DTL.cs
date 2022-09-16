using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_GAR_DTL
    {
        public string COY_CODE { get; set; } = null!;
        public string GAR_NO { get; set; } = null!;
        public string GAR_ITEM { get; set; } = null!;
        public string? PO_ITEM { get; set; }
        public string? ITEM_NO { get; set; }
        public string? UOM { get; set; }
        public decimal? ARRIVAL_QTY { get; set; }
        public decimal? REJECT_QTY { get; set; }
        public decimal? PROBLEM_QTY { get; set; }
        public decimal? RECEIVE_QTY { get; set; }
        public decimal? PO_QTY { get; set; }
        public decimal? UNIT_PRICE { get; set; }
        public decimal? AMT { get; set; }
        public decimal? AMT_IDR { get; set; }
        public string? ACCT_NO { get; set; }
        public string? VOUCH_ITEM { get; set; }
        public string? GTR_NO { get; set; }
        public string? GRR_NO { get; set; }
        public string? CHARGED_ITEM_NO { get; set; }
        public string? PR_NO { get; set; }
    }
}
