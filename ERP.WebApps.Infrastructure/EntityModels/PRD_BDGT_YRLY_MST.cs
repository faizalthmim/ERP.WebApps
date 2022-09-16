using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_BDGT_YRLY_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string EMP_DEPT_CODE { get; set; } = null!;
        public string PRDCT_CODE { get; set; } = null!;
        public string PROD_YEAR { get; set; } = null!;
        public decimal? QTY_M1 { get; set; }
        public decimal? QTY_M2 { get; set; }
        public decimal? QTY_M3 { get; set; }
        public decimal? QTY_M4 { get; set; }
        public decimal? QTY_M5 { get; set; }
        public decimal? QTY_M6 { get; set; }
        public decimal? QTY_M7 { get; set; }
        public decimal? QTY_M8 { get; set; }
        public decimal? QTY_M9 { get; set; }
        public decimal? QTY_M10 { get; set; }
        public decimal? QTY_M11 { get; set; }
        public decimal? QTY_M12 { get; set; }
        public decimal? DAY_M1 { get; set; }
        public decimal? DAY_M2 { get; set; }
        public decimal? DAY_M3 { get; set; }
        public decimal? DAY_M4 { get; set; }
        public decimal? DAY_M5 { get; set; }
        public decimal? DAY_M6 { get; set; }
        public decimal? DAY_M7 { get; set; }
        public decimal? DAY_M8 { get; set; }
        public decimal? DAY_M9 { get; set; }
        public decimal? DAY_M10 { get; set; }
        public decimal? DAY_M11 { get; set; }
        public decimal? DAY_M12 { get; set; }
        public string? REMARK { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
