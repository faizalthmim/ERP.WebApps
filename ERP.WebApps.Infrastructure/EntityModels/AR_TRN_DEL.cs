using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class AR_TRN_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string AR_NO { get; set; } = null!;
        public int SEQ_NO { get; set; }
        public string? AR_RECEIPT_NO { get; set; }
        public string? TRN_TYPE { get; set; }
        public string? VOUCH_NO { get; set; }
        public string? VOUCH_DATE { get; set; }
        public string? REMARK { get; set; }
        public string? PROC_MONTH { get; set; }
        public string? UNTT { get; set; }
        public string? REC_CODE { get; set; }
        public string? REC_KIND { get; set; }
        public string? PAYEE_TYPE { get; set; }
        public string? PAYEE_NO { get; set; }
        public string? ACCT_NO { get; set; }
        public string? DOC_TYPE { get; set; }
        public string? DOC_NO { get; set; }
        public string? INV_NO { get; set; }
        public string? PPN_ACCT_NO { get; set; }
        public string? PPH_ACCT_NO { get; set; }
        public string? CURR_CODE { get; set; }
        public decimal? CURR_RATE { get; set; }
        public decimal? FOREIGN_AMT { get; set; }
        public decimal? AMT { get; set; }
        public decimal? BASC_AMT { get; set; }
        public decimal? PPN_AMT { get; set; }
        public decimal? PPH_AMT { get; set; }
        public decimal? DISC_AMT { get; set; }
        public string? INV_DATE { get; set; }
        public string? DUE_DATE { get; set; }
        public decimal? QTY_TON { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? PNL_UPD_ID { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? DEL_TYPE { get; set; }
    }
}
