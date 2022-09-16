using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_GTR_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string GTR_NO { get; set; } = null!;
        public string? TRANSPORT_DATE { get; set; }
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? ARRIVED_AT { get; set; }
        public string? TRANSPORT_TO { get; set; }
        public string? REF_NO { get; set; }
        public string? REMARK { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
