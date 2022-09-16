using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PUR_PO_DTL
    {
        public string COY_CODE { get; set; } = null!;
        public string PO_NO { get; set; } = null!;
        public string PO_ITEM { get; set; } = null!;
        public string PR_NO { get; set; } = null!;
        public string? PR_ITEM { get; set; }
        public string? ITEM_NO { get; set; }
        public string? UOM { get; set; }
        public decimal? QTY { get; set; }
        public decimal? UNIT_PRICE { get; set; }
        public decimal? AMT { get; set; }
        public decimal? AMT_IDR { get; set; }
        public string? DETAIL_DESC { get; set; }
    }
}
