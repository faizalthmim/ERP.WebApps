using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRF_MST_INFO
    {
        public string COY_CODE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public string? EMP_NO { get; set; }
        public string? EMP_PLAN_CODE { get; set; }
        public string? EMP_DEPT_CODE { get; set; }
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? COST_CTR { get; set; }
        public string? DUE_DATE { get; set; }
        public string? PURPOSE { get; set; }
        public string? REMARK { get; set; }
        public decimal? PAY_AMT { get; set; }
        public decimal? PPN_AMT { get; set; }
        public decimal? PPH_AMT { get; set; }
        public decimal? PAY_FOREIGN { get; set; }
        public decimal? PPN_FOREIGN { get; set; }
        public decimal? PPH_FOREIGN { get; set; }
        public string? PPN_TYPE { get; set; }
        public decimal? PPN_RATE { get; set; }
        public bool? FLAG_PPN { get; set; }
        public bool? FLAG_PPH { get; set; }
        public string? PAY_TYPE { get; set; }
        public string? PAYEE_TYPE { get; set; }
        public string? PAY_TO { get; set; }
        public string? BANK_NAME { get; set; }
        public string? BANK_ACCT_NO { get; set; }
        public string? BANK_ACCT_NAME { get; set; }
        public string? PAY_ACCT_NO { get; set; }
        public string? PAY_TRN_CODE { get; set; }
        public string? PPN_ACCT_NO { get; set; }
        public string? PPH_ACCT_NO { get; set; }
        public string? VOUCH_NO { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? STAT_CODE { get; set; }
        public bool? FLAG_FOREIGN { get; set; }
        public bool? AUTO_VCH { get; set; }
        public string? VCH_RECURR { get; set; }
        public string? INVOICE_NO { get; set; }
        public string? PPN_BANK_ACCT_NO { get; set; }
        public string? PAY_VOUCH_NO { get; set; }
        /// <summary>
        /// (0 = &apos;Outstanding&apos;, 1 = &apos;Settled&apos;, 2 = &apos;Paid&apos;)
        /// </summary>
        public string? SETTLE_CODE { get; set; }
        public string? SETTLE_DATE { get; set; }
        public string? PAID_DATE { get; set; }
        public decimal? BAL_AMT { get; set; }
        public bool? FLAG_PPH_ON_PRF_CERTIFY { get; set; }
        public decimal? C_TOT_PAY_AMT { get; set; }
    }
}
