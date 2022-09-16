using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_ADJ_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string ADJ_NO { get; set; } = null!;
        public string? ADJ_DATE { get; set; }
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? WH_CODE { get; set; }
        public string? ADJ_TYPE { get; set; }
        public string? REASON { get; set; }
        public string? REMARK { get; set; }
        public string? VOUCH_NO { get; set; }
        public string? PROC_MONTH { get; set; }
        public string? STAT_CODE { get; set; }
        public decimal? ADJ_AMT { get; set; }
        public string? CURR_CODE { get; set; }
        public decimal? CURR_RATE { get; set; }
        public string? PURPOSE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
