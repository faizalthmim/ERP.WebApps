using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PUR_PR_HIST
    {
        public string COY_CODE { get; set; } = null!;
        public string PR_NO { get; set; } = null!;
        public int SEQ_NO { get; set; }
        public string? CLOSE_STAT { get; set; }
        public DateTime? CLOSE_DATE { get; set; }
        public string? REASON { get; set; }
        public string? REQUEST_BY { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
    }
}
