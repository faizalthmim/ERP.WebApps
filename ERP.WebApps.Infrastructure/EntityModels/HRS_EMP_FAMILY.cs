using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class HRS_EMP_FAMILY
    {
        public string COY_CODE { get; set; } = null!;
        public string EMP_NO { get; set; } = null!;
        public string? NAME { get; set; }
        public string? PLACE_OF_BIRTH { get; set; }
        public string? DATE_OF_BIRTH { get; set; }
        public string? RELATIONSHIP { get; set; }
        public string? ADDR { get; set; }
        public string? RELIGION { get; set; }
        public string? ID_TYPE { get; set; }
        public string? ID_NO { get; set; }
        public byte? ISMEDICAL { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
