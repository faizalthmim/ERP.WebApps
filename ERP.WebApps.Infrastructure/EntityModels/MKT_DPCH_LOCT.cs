using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_DPCH_LOCT
    {
        public string COY_CODE { get; set; } = null!;
        public string DPCH_LOCT { get; set; } = null!;
        public string? UNTT { get; set; }
        public string? DPCH_TYPE { get; set; }
        public string? DPCH_LOCT_NAME { get; set; }
        public string? DPCH_ADD1 { get; set; }
        public string? DPCH_ADD2 { get; set; }
        public string? DPCH_ADD3 { get; set; }
        public string? AREA_CODE { get; set; }
        public string? ZONE_CODE { get; set; }
        public string? DEST_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
