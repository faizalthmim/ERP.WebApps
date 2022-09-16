using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRE_PROJ_TRN_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string PROJ_NO { get; set; } = null!;
        public int TRN_SEQ { get; set; }
        public string? TRN_TYPE { get; set; }
        public DateTime? TRN_DATE { get; set; }
        public string? TRN_CTGR { get; set; }
        public string? ACCT_NO { get; set; }
        public string? TRN_DESC { get; set; }
        public decimal? TRN_QTY { get; set; }
        public decimal? TRN_AMT { get; set; }
        public string? REMARK { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? VOUCH_NO { get; set; }
        public string? VOUCH_ITEM { get; set; }
        public string? PROC_MONTH { get; set; }
        public string? COST_CTR { get; set; }
        public string C_TRN_TYPE { get; set; } = null!;
        public string? C_TRN_MONTH { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
    }
}
