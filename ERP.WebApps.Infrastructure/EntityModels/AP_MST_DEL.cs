using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class AP_MST_DEL
    {
        public string? COY_CODE { get; set; }
        public string? AP_NO { get; set; }
        public string? UNTT { get; set; }
        public string? REC_CODE { get; set; }
        public string? REC_KIND { get; set; }
        public string? PAYEE_TYPE { get; set; }
        public string? PAYEE_NO { get; set; }
        public string? ACCT_NO_AP_NOT_YET_INVOICED { get; set; }
        public string? ACCT_NO_AP_INVOICED { get; set; }
        public string? DOC_NO { get; set; }
        public string? DOC_DATE { get; set; }
        public string? PO_NO { get; set; }
        public string? CURR_CODE { get; set; }
        public string? REMARK { get; set; }
        public string? DUE_DATE { get; set; }
        public string? PPN_ACCT_NO { get; set; }
        public string? PPH_ACCT_NO { get; set; }
        public string? VOUCH_NO { get; set; }
        public string? VOUCH_DATE { get; set; }
        public string? VOUCH_NO_TEMP { get; set; }
        public decimal? BASIC_AMT { get; set; }
        public decimal? PPN_AMT { get; set; }
        public decimal? PPH_AMT { get; set; }
        public decimal? AP_AMT_NOT_YET_INVOICED { get; set; }
        public decimal? AP_AMT_INVOICED { get; set; }
        public decimal? ADJ_AMT_AP_NOT_YET_INVOICED { get; set; }
        public decimal? ADJ_AMT_AP_INVOICED { get; set; }
        public decimal? PAY_AMT_AP_NOT_YET_INVOICED { get; set; }
        public decimal? PAY_AMT_AP_INVOICED { get; set; }
        public string? SETTLE_BY { get; set; }
        public string? SETTLE_DATE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? PNL_CRE_ID { get; set; }
        public string? PNL_UPD_ID { get; set; }
        public decimal? C_TOT_AP_AMT { get; set; }
        public decimal? C_BAL_AMT_AP_NOT_YET_INVOICED { get; set; }
        public decimal? C_BAL_AMT_AP_INVOICED { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? PNL_DEL_ID { get; set; }
    }
}
