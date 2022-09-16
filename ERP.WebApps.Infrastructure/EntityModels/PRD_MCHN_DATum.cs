using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_MCHN_DATum
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string MCHN_TYPE { get; set; } = null!;
        public string MCHN_PROC_STG { get; set; } = null!;
        public string MCHN_PROC_SEQ { get; set; } = null!;
        public string MCHN_SEQ_NO { get; set; } = null!;
        public DateTime? START_TIME { get; set; }
        public DateTime? END_TIME { get; set; }
        public decimal? WEIGHT { get; set; }
        public decimal? MOISTURE { get; set; }
        public string? STAT_CODE { get; set; }
        public decimal? PWR_CONSUMPTION { get; set; }
        public string? CRTFY_FORM_NO { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? UPD_BY { get; set; }
    }
}
