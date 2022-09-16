using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_DEST_REF
    {
        public string COY_CODE { get; set; } = null!;
        public string AREA_CODE { get; set; } = null!;
        public string ZONE_CODE { get; set; } = null!;
        public string DEST_CODE { get; set; } = null!;
        public string? DEST_NAME { get; set; }
        public string? LVL_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
