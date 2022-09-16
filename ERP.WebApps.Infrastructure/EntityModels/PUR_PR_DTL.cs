using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PUR_PR_DTL
    {
        public string COY_CODE { get; set; } = null!;
        public string PR_NO { get; set; } = null!;
        public string PR_ITEM { get; set; } = null!;
        public string? ITEM_NO { get; set; }
        public string? UOM { get; set; }
        public decimal? REQ_QTY { get; set; }
        public decimal? UNIT_PRICE { get; set; }
        public decimal? REQ_AMT { get; set; }
        public string? DETAIL_DESC { get; set; }
        public string? PO_NO { get; set; }
        public string? PO_ITEM { get; set; }
        /// <summary>
        /// 1 for HO, 2 for Site
        /// </summary>
        public string? PURCHASE_AT { get; set; }
        public string? REASON_NOT_YET_ORDERED { get; set; }
        public string? PURCHASER_EMP_NO { get; set; }
    }
}
