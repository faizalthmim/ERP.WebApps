using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_GRR_DTL
    {
        public string COY_CODE { get; set; } = null!;
        public string GRR_NO { get; set; } = null!;
        public string GRR_ITEM { get; set; } = null!;
        public string? PO_ITEM { get; set; }
        public string? ITEM_NO { get; set; }
        public string? UOM { get; set; }
        public string? RACK_LOCT { get; set; }
        public decimal? RCV_QTY { get; set; }
        public decimal? UNIT_PRICE { get; set; }
        public decimal? AMT { get; set; }
        public decimal? AMT_IDR { get; set; }
        public string? ACCT_NO { get; set; }
        public string? VOUCH_ITEM { get; set; }
        public string? CHARGED_ITEM_NO { get; set; }
        public string? PR_NO { get; set; }
    }
}
