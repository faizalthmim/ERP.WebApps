using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_DPCH_REF
    {
        public string COY_CODE { get; set; } = null!;
        public string EFF_DATE { get; set; } = null!;
        public string DPCH_LOCT { get; set; } = null!;
        public string PROD_CODE { get; set; } = null!;
        public short DPCH_STAG_CODE { get; set; }
        public string? DPCH_STAG_DESC { get; set; }
        public string? DPCH_STAG_ROLE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
