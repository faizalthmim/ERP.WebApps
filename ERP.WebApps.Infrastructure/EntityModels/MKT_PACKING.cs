using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_PACKING
    {
        public string COY_CODE { get; set; } = null!;
        public string PACK_CODE { get; set; } = null!;
        public string BRAND_CODE { get; set; } = null!;
        public string BAG_TYPE { get; set; } = null!;
        public string? PACK_NAME { get; set; }
        public string? BRAND_NAME { get; set; }
        public string? BAG_NAME { get; set; }
        public decimal? BAG_SIZE { get; set; }
        public string? PACK_UOM { get; set; }
        public bool? BLOCK_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
