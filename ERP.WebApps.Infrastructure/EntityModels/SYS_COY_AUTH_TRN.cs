using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_COY_AUTH_TRN
    {
        public string USER_ID { get; set; } = null!;
        public string COY_CODE { get; set; } = null!;
        public byte? BLOCK_CODE { get; set; }
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? WORK_PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? PAYEE_NO { get; set; }
    }
}
