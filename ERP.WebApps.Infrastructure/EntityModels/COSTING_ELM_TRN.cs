using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class COSTING_ELM_TRN
    {
        public string COY_CODE { get; set; } = null!;
        public string PROC_MONTH { get; set; } = null!;
        public string PROCESS_SEQ { get; set; } = null!;
        public string PROCESS_SUB_SEQ { get; set; } = null!;
        public string DATA_TYPE { get; set; } = null!;
        public string REC_CODE { get; set; } = null!;
        public string MAT_TYPE { get; set; } = null!;
        public string REC_TYPE { get; set; } = null!;
        public string CMT_TYPE { get; set; } = null!;
        public string ACCT_NO_FROM { get; set; } = null!;
        public string COST_CTR_FROM { get; set; } = null!;
        public string? ACCT_NO_TO { get; set; }
        public string? COST_CTR_TO { get; set; }
        public string? COST_CTGR { get; set; }
        public string? COST_ELM { get; set; }
        public decimal? QTY { get; set; }
        public decimal? AMT { get; set; }
        public decimal? UNIT_PRICE { get; set; }
        public string? VOUCH_NO { get; set; }
        public string? VOUCH_ITEM { get; set; }
    }
}
