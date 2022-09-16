using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class ADV_MST
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
        public string? PAYEE_TYPE { get; set; }
        public string? PAYEE_NO { get; set; }
        public string? REMARK { get; set; }
        public string? CLR_REMARK { get; set; }
        public decimal? ADV_AMT { get; set; }
        public decimal? CLR_AMT { get; set; }
        public decimal? RTN_AMT { get; set; }
        public decimal? PPN_AMT { get; set; }
        public decimal? PPH_AMT { get; set; }
        public decimal? PPN_AMT_ON_CLR { get; set; }
        public decimal? PPH_AMT_ON_CLR { get; set; }
        public string? PAY_TYPE { get; set; }
        public string? BANK_NAME { get; set; }
        public string? BANK_ACCT_NO { get; set; }
        public string? BANK_ACCT_NAME { get; set; }
        public string? CONTACT_PERSON { get; set; }
        public string? EMAIL { get; set; }
        public string? EXTENSION { get; set; }
        public string? ADV_BANK_ACCT_NO { get; set; }
        public string? ADV_BANK_TRN_CLS { get; set; }
        public string? ADV_OTHER_BANK_ACCT_NO { get; set; }
        public string? ADV_OTHER_BANK_TRN_CLS { get; set; }
        public string? PPN_ACCT_NO { get; set; }
        public string? PPH_ACCT_NO { get; set; }
        public string? ADV_VOUCH_NO { get; set; }
        public string? CLR_VOUCH_NO { get; set; }
        public string? STAT_CODE { get; set; }
        public string? PPN_FLAG { get; set; }
        public string? PPH_FLAG { get; set; }
        public string? PPN_FLAG_ON_CLR { get; set; }
        public string? PPH_FLAG_ON_CLR { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? PPN_CREDITABLE_FLAG { get; set; }
        public string? PPN_CREDIT_ON_CLR_FLAG { get; set; }
        /// <summary>
        /// PPN Currency Rate
        /// </summary>
        public decimal? PPN_RATE { get; set; }
        /// <summary>
        /// PPN Currency Rate
        /// </summary>
        public decimal? PPN_RATE_CLR { get; set; }
        public string? ADV_ACCT_NO { get; set; }
        public decimal? PPN_FOREIGN_AMT { get; set; }
        public decimal? PPH_FOREIGN_AMT { get; set; }
        public decimal? PPN_FOREIGN_AMT_ON_CLR { get; set; }
        public decimal? PPH_FOREIGN_AMT_ON_CLR { get; set; }
        public string? ADV_VOUCH_DATE { get; set; }
        public string? ADV_PAY_DATE { get; set; }
        public string? SETTLE_DATE { get; set; }
        public string? AUTO_VCH { get; set; }
        public string? AUTO_VCH_CLR { get; set; }
        public string? PPN_USE_BASIC_RATE_ON_ADV { get; set; }
        public string? PO_NO { get; set; }
        public decimal? AP_AMT { get; set; }
        public decimal? AP_AMT_FOREIGN { get; set; }
        public string? NON_AP_ACCT_NO { get; set; }
        public decimal? C_TOT_ADV_AMT { get; set; }
        public decimal? C_TOT_CLR_AMT { get; set; }
    }
}
