using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_ADJ_DTL
    {
        public string COY_CODE { get; set; } = null!;
        public string ADJ_NO { get; set; } = null!;
        public string ADJ_ITEM { get; set; } = null!;
        public string? ITEM_NO { get; set; }
        public string? UOM { get; set; }
        public string? RACK_LOCT { get; set; }
        public decimal? QTY { get; set; }
        public decimal? UNIT_PRICE { get; set; }
        public decimal? AMT { get; set; }
        public decimal? AMT_IDR { get; set; }
        public string? INV_ACCT_NO { get; set; }
        public string? VOUCH_ITEM { get; set; }
    }
}
