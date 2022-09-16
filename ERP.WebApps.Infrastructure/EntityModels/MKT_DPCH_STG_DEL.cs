using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_DPCH_STG_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string SDO_NO { get; set; } = null!;
        public short DPCH_STAG_CODE { get; set; }
        public short DPCH_STAG_SEQ { get; set; }
        public string DELV_DATE { get; set; } = null!;
        public string VSL_TUG_CODE { get; set; } = null!;
        public string? QTY_UOM { get; set; }
        public decimal? QTY_WET { get; set; }
        public decimal? QTY_DRY { get; set; }
        public decimal? MOISTURE { get; set; }
        public string? DOC_QLT_NO { get; set; }
        public string? REMARK { get; set; }
        public string? MANUAL { get; set; }
        public string? MANUAL_REASON { get; set; }
        public string? PGM_ID { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? DEL_TYPE { get; set; }
    }
}
