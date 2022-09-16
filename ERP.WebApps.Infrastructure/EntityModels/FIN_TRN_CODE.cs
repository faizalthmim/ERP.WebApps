using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_TRN_CODE
    {
        public string COY_CODE { get; set; } = null!;
        public string TRN_CODE { get; set; } = null!;
        public string GROUP_CODE { get; set; } = null!;
        public string? GROUP_TITLE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? BLOCK_CODE { get; set; }
    }
}
