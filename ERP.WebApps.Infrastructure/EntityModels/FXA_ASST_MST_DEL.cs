using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FXA_ASST_MST_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string PROC_MONTH { get; set; } = null!;
        public string ASST_NO { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string DEPT_CODE { get; set; } = null!;
        public string? COST_CTR { get; set; }
        public string? STAT_CODE { get; set; }
        public string ACCT_NO { get; set; } = null!;
        public decimal? QTY { get; set; }
        public decimal? ASST_VAL { get; set; }
        public decimal? ASST_VAL_ADJ { get; set; }
        public decimal? ACC_DEPR { get; set; }
        public decimal? ACC_DEPR_ADJ { get; set; }
        public decimal? MTHLY_DEPR { get; set; }
        public decimal? LIFE_YEAR { get; set; }
        public string? DISPOSE_DATE { get; set; }
        public string? ASST_SPEC { get; set; }
        public string? ITEM_SPEC { get; set; }
        public string? UOM { get; set; }
        public string? SERIAL_NO { get; set; }
        public string? MIS_NO { get; set; }
        public string? ACQ_DATE { get; set; }
        public string? USE_DATE { get; set; }
        public decimal? ORIG_VAL { get; set; }
        public string? PROJ_NO { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
    }
}
