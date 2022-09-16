using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class COSTING_ACCT_REF
    {
        public string COY_CODE { get; set; } = null!;
        public string PROCESS_SEQ { get; set; } = null!;
        public string PROCESS_SUB_SEQ { get; set; } = null!;
        public string DATA_TYPE { get; set; } = null!;
        public string REC_CODE { get; set; } = null!;
        public string MAT_TYPE { get; set; } = null!;
        public string REC_TYPE { get; set; } = null!;
        public string CMT_TYPE { get; set; } = null!;
        public string ACCT_NO_FROM { get; set; } = null!;
        public string COST_CTR_FROM { get; set; } = null!;
        public string COST_CTGR { get; set; } = null!;
        public string? ACCT_NO_TO { get; set; }
        public string? COST_CTR_TO { get; set; }
        public string? ACCT_NO_FROM_DISPLAYED_IN_VCH { get; set; }
        public string? QUERY_FOR_QTY { get; set; }
        public string? QUERY_FOR_AMT { get; set; }
        public string? PROPORTION_BY_QTY { get; set; }
        public string? PROCESS_SEQ_EXCLUDED { get; set; }
        public string? VOUCH_SEQ { get; set; }
        public string? VOUCH_ITEM { get; set; }
        public string? VOUCH_ITEM_DESC { get; set; }
        public string? GROUP_BY_ACCT_NO_FROM { get; set; }
        public string? NEED_TO_CHECK_QTY_VALUE { get; set; }
        public string? QUERY_FOR_VARIANCE { get; set; }
    }
}
