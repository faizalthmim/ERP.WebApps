using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class Z_CAD_ADV_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public string? EMP_NO { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? COST_CTR { get; set; }
        public string? DUE_DATE { get; set; }
        public string? PURPOSE { get; set; }
        public string? DESCRIPTION { get; set; }
        public decimal? ADV_AMT { get; set; }
        public decimal? EXP_AMT { get; set; }
        public decimal? RETURN_AMT { get; set; }
        public string? PAY_METHOD { get; set; }
        public string? BANK_NAME { get; set; }
        public string? BANK_ACCT_NAME { get; set; }
        public string? BANK_ACCT_NO { get; set; }
        public string? CONTACT_PERSON { get; set; }
        public string? EMAIL_ADDR { get; set; }
        public string? PHONE_EXT { get; set; }
        public string? REMARK { get; set; }
        public string? ADV_VOUCH_NO { get; set; }
        public string? EXP_VOUCH_NO { get; set; }
        public string? STATUS { get; set; }
        public string CRE_BY { get; set; } = null!;
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
