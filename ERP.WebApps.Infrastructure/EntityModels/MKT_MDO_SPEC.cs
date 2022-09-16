using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_MDO_SPEC
    {
        public string COY_CODE { get; set; } = null!;
        public string MDO_NO { get; set; } = null!;
        public string SPEC_TYPE { get; set; } = null!;
        public string SPEC_ITEM { get; set; } = null!;
        public long SPEC_SEQ { get; set; }
        public string? SPEC_VALUE { get; set; }
        public string? SPEC_UOM { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
