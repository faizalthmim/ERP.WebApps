using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string ITEM_NO { get; set; } = null!;
        public string? PART_NO { get; set; }
        public string? BAR_CODE { get; set; }
        public string? ITEM_DESC { get; set; }
        public string? ITEM_GROUP { get; set; }
        public string? PURCHASE_UOM { get; set; }
        public string? USAGE_UOM { get; set; }
        public decimal? CONVERT_UOM { get; set; }
        /// <summary>
        /// SUPPLIER&apos;S REFERENCE NO. FOR THIS PARTICULAR ITEM
        /// </summary>
        public string? SUPP_REF_NO { get; set; }
        public string? PURCH_EMP_NO { get; set; }
        /// <summary>
        /// Percentage of tolerance for goods receipt (can be over or under) against PO quantity
        /// </summary>
        public decimal? QTY_RCV_TOLERANCE_LIMIT { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? ACTIVE_CODE { get; set; }
        public string? IS_SERVICE { get; set; }
        public string? QC_NEEDED { get; set; }
        public decimal? MINIMUM_STOCK { get; set; }
        public string? ITEM_STATUS { get; set; }
    }
}
