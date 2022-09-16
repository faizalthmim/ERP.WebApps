using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_STOCK_TRN
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string WH_CODE { get; set; } = null!;
        public string PRDCT_DATE { get; set; } = null!;
        public int SEQ { get; set; }
        public string PRDCT_CODE { get; set; } = null!;
        public string TYPE { get; set; } = null!;
        public string? RELATED_FORM_NO { get; set; }
        public decimal? WET_QTY { get; set; }
        public decimal? DRY_QTY { get; set; }
        public string? SMPL_FORM_NO { get; set; }
        public decimal? MOIST { get; set; }
        public string? REASON { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? UPD_BY { get; set; }
    }
}
