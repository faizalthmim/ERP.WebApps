using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FXA_ASST_DEF
    {
        public string COY_CODE { get; set; } = null!;
        public string ASST_NO { get; set; } = null!;
        public string? ASST_SPEC { get; set; }
        public string? ITEM_SPEC { get; set; }
        public string? UOM { get; set; }
        public string? SERIAL_NO { get; set; }
        public string? MIS_NO { get; set; }
        public string? ACQ_DATE { get; set; }
        public string? USE_DATE { get; set; }
        public decimal? ORIG_VAL { get; set; }
        public string? PROJ_NO { get; set; }
        public string? ASST_LOCT { get; set; }
        public string? FA_GRP { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
