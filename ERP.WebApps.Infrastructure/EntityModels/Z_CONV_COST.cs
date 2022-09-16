using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class Z_CONV_COST
    {
        public string COY_CODE { get; set; } = null!;
        public string COST_CTR { get; set; } = null!;
        public string? DEPT_CODE { get; set; }
        public string? NEW_COST { get; set; }
    }
}
