using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_GAR_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string GAR_NO { get; set; } = null!;
        public string? PO_NO { get; set; }
        public string? ARRIVAL_SEQ { get; set; }
        public string? ARRIVAL_DATE { get; set; }
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? WH_CODE { get; set; }
        public string? PAYEE_TYPE { get; set; }
        public string? PAYEE_NO { get; set; }
        public string? DO_NO { get; set; }
        public string? REMARK { get; set; }
        public string? TRANSPORT_OTHER_LOCT { get; set; }
        public string? VOUCH_NO { get; set; }
        public string? PROC_MONTH { get; set; }
        public string? STAT_CODE { get; set; }
        public string? AP_TYPE { get; set; }
        public string? AP_NO { get; set; }
        public string? RELATED_INV_ITEMS_FLAG { get; set; }
        public string? PPN_FLAG { get; set; }
        public string? PPN_ACCT_NO { get; set; }
        public string? CURR_CODE { get; set; }
        public decimal? CURR_RATE { get; set; }
        public decimal? PPN_AMT { get; set; }
        public decimal? GAR_AMT { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public decimal? TOT_GAR_AMT { get; set; }
        public decimal? GAR_AMT_IDR { get; set; }
        public decimal? PPN_AMT_IDR { get; set; }
        public decimal? TOT_GAR_AMT_IDR { get; set; }
    }
}
