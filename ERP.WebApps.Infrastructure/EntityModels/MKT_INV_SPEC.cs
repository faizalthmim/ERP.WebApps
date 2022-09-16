using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_INV_SPEC
    {
        public string COY_CODE { get; set; } = null!;
        public string INV_NO { get; set; } = null!;
        public string SPEC_TYPE { get; set; } = null!;
        public long SPEC_SEQ { get; set; }
        public string SPEC_ITEM { get; set; } = null!;
        public string? SPEC_VALUE { get; set; }
        public string? SPEC_VALUE_Min { get; set; }
        public string? SPEC_VALUE_Max { get; set; }
        public string? SPEC_RESULT { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
