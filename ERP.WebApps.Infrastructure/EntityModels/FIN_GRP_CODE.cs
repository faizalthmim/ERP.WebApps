using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_GRP_CODE
    {
        public string GROUP_TYPE { get; set; } = null!;
        public string GROUP_CODE { get; set; } = null!;
        public string GROUP_TITLE { get; set; } = null!;
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? UPDATE_FLAG { get; set; }
        public string? BOLD_FLAG { get; set; }
    }
}
