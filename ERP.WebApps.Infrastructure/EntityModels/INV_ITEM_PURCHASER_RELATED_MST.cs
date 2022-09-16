using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_ITEM_PURCHASER_RELATED_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string ITEM_NO { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string? PURCHASER_EMP_NO { get; set; }
    }
}
