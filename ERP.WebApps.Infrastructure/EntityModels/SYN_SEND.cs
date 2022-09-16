using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYN_SEND
    {
        public string SERVER { get; set; } = null!;
        public string TO_SERVER { get; set; } = null!;
        public string TRN_TABLE { get; set; } = null!;
        public string TRN_KEY { get; set; } = null!;
        public string TRN_CONDITION { get; set; } = null!;
        public long? INTERVAL { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
