using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_PROC_STG_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public int PROC_SEQ { get; set; }
        public string PROC_STG_CODE { get; set; } = null!;
        public string? PROC_STG_DESC { get; set; }
        public bool? IS_BUDGET { get; set; }
        public bool? IS_STOCK { get; set; }
        public bool? IS_POWER { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
