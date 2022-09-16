using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class OTH_DOC
    {
        public string COY_CODE { get; set; } = null!;
        public string DOC_TYPE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string DEPT_CODE { get; set; } = null!;
        public string DOC_DATE { get; set; } = null!;
        public string DOC_NO { get; set; } = null!;
        public string DOC_NAME { get; set; } = null!;
        public string? CATEGORY { get; set; }
        public string? REMARK { get; set; }
        public int? TTL_ATTCH { get; set; }
        public string STAT_CODE { get; set; } = null!;
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
