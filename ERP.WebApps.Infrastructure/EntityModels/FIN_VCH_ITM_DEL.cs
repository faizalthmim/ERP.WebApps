using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_VCH_ITM_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string VOUCH_NO { get; set; } = null!;
        public string VOUCH_ITEM { get; set; } = null!;
        public string CNCL_CNTR { get; set; } = null!;
        public string? UNTT { get; set; }
        public string? VOUCH_TYPE { get; set; }
        public string? ACCT_NO { get; set; }
        public string? COST_CTR { get; set; }
        public string? VOUCH_DATE { get; set; }
        public decimal? DR_AMT { get; set; }
        public decimal? CR_AMT { get; set; }
        public decimal? DR_QTY { get; set; }
        public decimal? CR_QTY { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? TRN_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? REF_SYSTEM { get; set; }
        public string? REF_SUB_SYSTEM { get; set; }
        public string? AUTO { get; set; }
        public string? CHECKED_BY { get; set; }
        public DateTime? CHECKED_DATE { get; set; }
        public string? APPRV_BY { get; set; }
        public DateTime? APPRV_DATE { get; set; }
        public string? BANK_STATUS { get; set; }
        public string? BANK_REF_NO { get; set; }
        public string? BANK_PAID_DATE { get; set; }
        public string? C_VOUCH_MONTH { get; set; }
    }
}
