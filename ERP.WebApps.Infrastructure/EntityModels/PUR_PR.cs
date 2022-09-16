using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PUR_PR
    {
        public string COY_CODE { get; set; } = null!;
        public string PR_NO { get; set; } = null!;
        public DateTime? PR_DATE { get; set; }
        public string? STATUS { get; set; }
    }
}
