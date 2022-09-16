using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FXA_ASST_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string PROC_MONTH { get; set; } = null!;
        public string ASST_NO { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string DEPT_CODE { get; set; } = null!;
        public string COST_CTR { get; set; } = null!;
        public string STAT_CODE { get; set; } = null!;
        public string ACCT_NO { get; set; } = null!;
        public decimal? QTY { get; set; }
        public decimal? ASST_VAL { get; set; }
        public decimal? ASST_VAL_ADJ { get; set; }
        public decimal? ACC_DEPR { get; set; }
        public decimal? ACC_DEPR_ADJ { get; set; }
        public decimal? MTHLY_DEPR { get; set; }
        public decimal? MTHLY_DEPR_CIP { get; set; }
        public decimal? LIFE_YEAR { get; set; }
        public string? DISPOSE_DATE { get; set; }
        public decimal? C_NET_VAL { get; set; }
    }
}
