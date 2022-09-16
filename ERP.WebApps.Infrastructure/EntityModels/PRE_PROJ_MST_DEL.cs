using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRE_PROJ_MST_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string PROJ_NO { get; set; } = null!;
        public string? PROJ_NAME { get; set; }
        public string? PROJ_DESC { get; set; }
        public string UNTT { get; set; } = null!;
        public string? ACCT_NO { get; set; }
        public string? FIELD1 { get; set; }
        public string? FIELD2 { get; set; }
        public string? BUDG_REF_NO { get; set; }
        public decimal? BUDG_AMT { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? FINISH_DATE { get; set; }
        public decimal? ACCU_PROJ_COST { get; set; }
        public decimal? ACCU_PROJ_COST_ADJ { get; set; }
        public string? MAIN_PROJ_NO { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? ACTIVE_CODE { get; set; }
        public string? C_START_MONTH { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
    }
}
