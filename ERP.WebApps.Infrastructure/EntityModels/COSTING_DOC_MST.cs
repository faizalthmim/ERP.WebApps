using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class COSTING_DOC_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public string? EMP_NO { get; set; }
        public string? EMP_PLAN_CODE { get; set; }
        public string? EMP_DEPT_CODE { get; set; }
        public string? EMP_UNTT { get; set; }
        public string? REMARK { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
