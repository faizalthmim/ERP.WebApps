using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_GRR_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string GRR_NO { get; set; } = null!;
        public string? PO_NO { get; set; }
        public string? GRR_DATE { get; set; }
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? WH_CODE { get; set; }
        public string? RECEIVED_IN { get; set; }
        public string? PAYEE_TYPE { get; set; }
        public string? PAYEE_NO { get; set; }
        public string? REMARK { get; set; }
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
        public decimal? GRR_AMT { get; set; }
        public DateTime? COMPLETED_DATE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public decimal? TOT_GRR_AMT { get; set; }
        public decimal? GRR_AMT_IDR { get; set; }
        public decimal? PPN_AMT_IDR { get; set; }
        public decimal? TOT_GRR_AMT_IDR { get; set; }
    }
}
