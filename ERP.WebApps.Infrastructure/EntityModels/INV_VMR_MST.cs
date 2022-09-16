using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_VMR_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string VMR_NO { get; set; } = null!;
        public string? VMR_DATE { get; set; }
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? USED_FOR_UNTT { get; set; }
        public string? USED_FOR_PLAN_CODE { get; set; }
        public string? USED_FOR_DEPT_CODE { get; set; }
        public string? VENDOR_TYPE { get; set; }
        public string? GEN_DESC { get; set; }
        public string? REMARK { get; set; }
        public string? CREATED_TO_COY_CODE { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
