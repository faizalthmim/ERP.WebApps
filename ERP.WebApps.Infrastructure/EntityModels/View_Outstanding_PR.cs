using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class View_Outstanding_PR
    {
        public string COY_CODE { get; set; } = null!;
        public string PR_NO { get; set; } = null!;
        public string PR_ITEM { get; set; } = null!;
        public string? PR_DATE { get; set; }
        public string? EMP_DEPT_CODE { get; set; }
        public string? EMP_UNTT { get; set; }
        public string? EMP_PLAN_CODE { get; set; }
        public string? USED_DEPT_CODE { get; set; }
        public string? USED_UNTT { get; set; }
        public string? USED_PLAN_CODE { get; set; }
        public string? ITEM_DESC { get; set; }
        public string? UOM { get; set; }
        public decimal? REQ_QTY { get; set; }
        public decimal? REQ_AMT { get; set; }
        public string USER_ID { get; set; } = null!;
        public string? CLOSE_STAT { get; set; }
        public DateTime? CLOSE_DATE { get; set; }
        public string? CURR_CODE { get; set; }
        public string? PURCHASE_AT { get; set; }
        public string? PURCHASER_EMP_NO { get; set; }
        public string? ITEM_NO { get; set; }
    }
}
