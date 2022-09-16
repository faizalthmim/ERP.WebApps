using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class HRS_EMP_PREV_EMPLOYMENT_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string EMP_NO { get; set; } = null!;
        public string? COMPANY_NAME { get; set; }
        public string? JOIN_DATE { get; set; }
        public string? RESIGN_DATE { get; set; }
        public string? LAST_POSITION { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
    }
}
