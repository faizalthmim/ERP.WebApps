using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PUR_PR_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string PR_NO { get; set; } = null!;
        public string? DOC_NO { get; set; }
        public string? EMP_UNTT { get; set; }
        public string? EMP_PLAN_CODE { get; set; }
        public string? EMP_DEPT_CODE { get; set; }
        public string? WH_CODE { get; set; }
        public string? PR_DATE { get; set; }
        public string? GEN_DESC { get; set; }
        public string? PURPOSE { get; set; }
        public string? USED_UNTT { get; set; }
        public string? USED_PLAN_CODE { get; set; }
        public string? USED_DEPT_CODE { get; set; }
        public string? COST_CTR { get; set; }
        public string? EXPECTED_DATE { get; set; }
        public string? CURR_CODE { get; set; }
        public string? IS_BUDGETED { get; set; }
        public string? BUDGET_NO { get; set; }
        /// <summary>
        /// N for Normal, H for High
        /// </summary>
        public string? PRIORITY { get; set; }
        /// <summary>
        /// 1 for HO, 2 for Site
        /// </summary>
        public string? PURCHASE_AT { get; set; }
        /// <summary>
        /// TO TELL PURCHASER THAT REQUESTOR HAS SAMPLE OR NOT
        /// </summary>
        public string? SAMPLE { get; set; }
        public string? ASSET { get; set; }
        public string? RELATED_INV_ITEMS_FLAG { get; set; }
        public decimal? TOT_REQ_QTY { get; set; }
        public decimal? TOT_REQ_AMT { get; set; }
        public string? STAT_CODE { get; set; }
        /// <summary>
        /// To indicate whether this particular PR has been closed or not (0 for not closed, 1 for closed)
        /// </summary>
        public string? CLOSE_STAT { get; set; }
        public DateTime? CLOSE_DATE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? CLOSE_BY { get; set; }
    }
}
