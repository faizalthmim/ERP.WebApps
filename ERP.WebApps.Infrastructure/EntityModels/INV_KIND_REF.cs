using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_KIND_REF
    {
        public string INV_KIND { get; set; } = null!;
        public string INV_SUB_KIND { get; set; } = null!;
        public string? INV_KIND_DESC { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? BLOCK_CODE { get; set; }
    }
}
