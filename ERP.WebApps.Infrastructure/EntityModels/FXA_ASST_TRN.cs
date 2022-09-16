using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FXA_ASST_TRN
    {
        public string COY_CODE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public string? TRN_CODE { get; set; }
        public string? PROC_MONTH { get; set; }
        public string? ASST_NO { get; set; }
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? COST_CTR { get; set; }
        public string? ACCT_NO { get; set; }
        public decimal? QTY { get; set; }
        public decimal? ASST_VAL { get; set; }
        public decimal? ASST_VAL_ADJ { get; set; }
        public decimal? ACC_DEPR { get; set; }
        public decimal? ACC_DEPR_ADJ { get; set; }
        public string? UNTT_IN { get; set; }
        public string? PLAN_CODE_IN { get; set; }
        public string? DEPT_CODE_IN { get; set; }
        public string? COST_CTR_IN { get; set; }
        public string? ACCT_NO_IN { get; set; }
        public string? REMARK { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public decimal? LIFE_YEAR { get; set; }
        public string? DISPOSE_DATE { get; set; }
        public string? VOUCH_NO { get; set; }
    }
}
