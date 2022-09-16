using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_PORT_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string PORT_CODE { get; set; } = null!;
        public string? PORT_NAME { get; set; }
        public string? PORT_CTRY { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
