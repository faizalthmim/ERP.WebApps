using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class AR_RECEIPT_MST_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string PROC_MONTH { get; set; } = null!;
        public string AR_RECEIPT_NO { get; set; } = null!;
        public string? UNTT { get; set; }
        public string? PAYEE_TYPE { get; set; }
        public string? PAYEE_NO { get; set; }
        public string? RECEIPT_CTGR { get; set; }
        public string? RECEIPT_TYPE { get; set; }
        public string? RECEIPT_DATE { get; set; }
        public string? VOUCH_NO { get; set; }
        public string? VOUCH_DATE { get; set; }
        public string? PAY_REF_NO { get; set; }
        public string? DEPOSIT_ACCT_NO { get; set; }
        public string? DEBIT_ACCT_NO { get; set; }
        public string? DEBIT_TRN_CLASS { get; set; }
        public string? PPN_ACCT_NO { get; set; }
        public string? CURR_CODE { get; set; }
        public decimal? CURR_RATE { get; set; }
        public decimal? FOREIGN_AMT { get; set; }
        public decimal? RECEIPT_AMT { get; set; }
        public decimal? USED_AMT { get; set; }
        public decimal? ADJ_AMT { get; set; }
        public decimal? BAL_AMT { get; set; }
        public decimal? PPN_AMT { get; set; }
        public decimal? USED_PPN_AMT { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? FILE_NAME { get; set; }
        public string? BATCH_NO { get; set; }
        public string? SETTLE_BY { get; set; }
        public string? SETTLE_DATE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? PNL_UPD_ID { get; set; }
        public decimal? C_TOT_RECEIPT_AMT { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? DEL_TYPE { get; set; }
    }
}
