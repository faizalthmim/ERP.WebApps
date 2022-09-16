using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_MCHN_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string MCHN_CODE { get; set; } = null!;
        public string? MCHN_NAME { get; set; }
        public string? MCHN_BRAND { get; set; }
        public string? MCHN_MODEL { get; set; }
        public string? MCHN_SERIAL_NO { get; set; }
        public decimal? STD_MCH_CAPACITY { get; set; }
        public decimal? STD_KWH_CNSME { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
