using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_GTR_DTL
    {
        public string COY_CODE { get; set; } = null!;
        public string GTR_NO { get; set; } = null!;
        public string GAR_NO { get; set; } = null!;
        public string GAR_ITEM { get; set; } = null!;
        public string? PO_NO { get; set; }
        public string? PO_ITEM { get; set; }
        public string? PR_NO { get; set; }
        public string? PAYEE_TYPE { get; set; }
        public string? PAYEE_NO { get; set; }
        public string? ITEM_NO { get; set; }
        public string? UOM { get; set; }
        public decimal? ARRIVAL_QTY { get; set; }
        public decimal? PO_QTY { get; set; }
        public decimal? GTR_QTY { get; set; }
        public decimal? GTR_QTY_TRANSIT { get; set; }
        public decimal? GTR_QTY_FINAL_RCV { get; set; }
        public string? GRR_NO { get; set; }
    }
}
