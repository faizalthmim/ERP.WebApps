using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_MIR_DTL
    {
        public string COY_CODE { get; set; } = null!;
        public string MIR_NO { get; set; } = null!;
        public string MIR_ITEM { get; set; } = null!;
        public string? USER_ITEM_DESC { get; set; }
        public string? USER_PURCHASE_UOM { get; set; }
        public string? USER_USAGE_UOM { get; set; }
        public decimal? USER_CONVERT_UOM { get; set; }
        public decimal? USER_QTY_RCV_TOLERANCE_LIMIT { get; set; }
        public string? USER_IS_SERVICE { get; set; }
        public string? COY_STD_ITEM_NO { get; set; }
        public string? COY_STD_ITEM_DESC { get; set; }
        public string? COY_STD_PURCHASE_UOM { get; set; }
        public string? COY_STD_USAGE_UOM { get; set; }
        public decimal? COY_STD_CONVERT_UOM { get; set; }
        public decimal? COY_STD_QTY_RCV_TOLERANCE_LIMIT { get; set; }
        public string? COY_STD_IS_SERVICE { get; set; }
        /// <summary>
        /// (&apos;N&apos; for New, &apos;E&apos; for Existing)
        /// </summary>
        public string? STATUS_ITEM { get; set; }
        public decimal? COY_STD_MINIMUM_STOCK { get; set; }
        public string? COY_STD_INV_ITEM_STATUS { get; set; }
        public decimal? USER_MINIMUM_STOCK { get; set; }
        public string? USER_INV_ITEM_STATUS { get; set; }
    }
}
