using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_RAW_MAT_DPCH_ST
    {
        public string COY_CODE { get; set; } = null!;
        public string PO_NO { get; set; } = null!;
        public string PO_ITEM { get; set; } = null!;
        public string ASSIGN_SEQ { get; set; } = null!;
        public short? LVL_CODE { get; set; }
        public string? DPCH_STAG_CODE { get; set; }
        public string? DPCH_STAG_SEQ { get; set; }
        public string? DELV_DATE { get; set; }
        public string? GAR_NO { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
