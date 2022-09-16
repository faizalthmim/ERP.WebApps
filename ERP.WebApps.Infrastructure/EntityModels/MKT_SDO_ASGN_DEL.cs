using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_SDO_ASGN_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string SDO_NO { get; set; } = null!;
        public string VSL_TUG_CODE { get; set; } = null!;
        public string? CAPT_NAME { get; set; }
        public string? VSL_CARRIER_CODE { get; set; }
        public short? TRIP { get; set; }
        public string? QTY_UOM { get; set; }
        public decimal? QTY_WET { get; set; }
        public decimal? QTY_DRY { get; set; }
        public string? ASGN_BY { get; set; }
        public string? ASGN_DATE { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? DEL_TYPE { get; set; }
    }
}
