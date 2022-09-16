using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_COST_BUDGET_TTV
    {
        public string COY_CODE { get; set; } = null!;
        public long BUDG_ID { get; set; }
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string DEPT_CODE { get; set; } = null!;
        public string YEAR { get; set; } = null!;
        public string MONTH { get; set; } = null!;
        public string ACCT_NO { get; set; } = null!;
        public string COST_CTR { get; set; } = null!;
        public string? CURR_CODE { get; set; }
        public decimal? BUDG_AMT { get; set; }
        public string? FILE_NAME { get; set; }
        public string? DOC_DATE { get; set; }
        public string? DOC_TYPE { get; set; }
        public string? DOC_NO { get; set; }
        public string? STAT_CODE { get; set; }
        public string? REMARK { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
