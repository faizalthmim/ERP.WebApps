using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_ORG_STR
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string DEPT_CODE { get; set; } = null!;
        public string? ORG_DESC { get; set; }
        public string? SHORT_DESC { get; set; }
        public string? EMP_NO { get; set; }
        public string? LVL_CODE { get; set; }
        public string? BLOCK_CODE { get; set; }
    }
}
