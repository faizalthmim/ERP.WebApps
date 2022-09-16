using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_PWR_TRN
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string MCHN_CODE { get; set; } = null!;
        public string PROC_STG_CODE { get; set; } = null!;
        public string PROD_DATE { get; set; } = null!;
        public string PRDCT_CODE { get; set; } = null!;
        public decimal? MR { get; set; }
        public decimal? QTY { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRTFY_FORM_NO { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? UPD_BY { get; set; }
    }
}
