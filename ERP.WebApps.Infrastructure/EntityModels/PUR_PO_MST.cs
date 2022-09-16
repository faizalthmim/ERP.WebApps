using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PUR_PO_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string PO_NO { get; set; } = null!;
        public string? DOC_NO { get; set; }
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? PO_DATE { get; set; }
        public string? PAYEE_TYPE { get; set; }
        public string? PAYEE_NO { get; set; }
        public string? GEN_DESC { get; set; }
        public string? REQUIRED_DATE { get; set; }
        public string? CURR_CODE { get; set; }
        public string? SHIP_TO { get; set; }
        public int? PAY_TERM { get; set; }
        public string? REMARK { get; set; }
        public string? BUDGET_NO { get; set; }
        public decimal? CURR_RATE { get; set; }
        public decimal? PPN_AMT { get; set; }
        public decimal? PO_AMT { get; set; }
        public string? STAT_CODE { get; set; }
        /// <summary>
        /// To indicate whether this particular PO has been closed or not (0 for not closed, 1 for closed)
        /// </summary>
        public string? CLOSE_STAT { get; set; }
        public DateTime? CLOSE_DATE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public decimal? TOT_PO_AMT { get; set; }
        public decimal? PO_AMT_IDR { get; set; }
        public decimal? TOT_PO_AMT_IDR { get; set; }
    }
}
