using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_COST_CTR
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string COST_CTR { get; set; } = null!;
        public string? COST_CTR_NAME { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? LOCT_CODE { get; set; }
        public string? PROJECT_NO { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? BLOCK_CODE { get; set; }
        public string? COST_CTGR { get; set; }
        public string? COST_GROUP_1 { get; set; }
    }
}
