using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_MIS_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string MIS_NO { get; set; } = null!;
        public string? MIS_DATE { get; set; }
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? WH_CODE { get; set; }
        public string? USED_FOR_UNTT { get; set; }
        public string? USED_FOR_PLAN_CODE { get; set; }
        public string? USED_FOR_DEPT_CODE { get; set; }
        public string? COST_CTR { get; set; }
        public string? PICK_UP_BY { get; set; }
        /// <summary>
        /// 0 for ready to be picked up; 1 for in the process of being picked up; 2 for complete picked up
        /// </summary>
        public string? PICK_UP_STATUS { get; set; }
        public string? REMARK { get; set; }
        public string? VOUCH_NO { get; set; }
        public string? PROC_MONTH { get; set; }
        public string? STAT_CODE { get; set; }
        public decimal? MIS_AMT { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
