using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class HRS_EMP_ADDR_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string EMP_NO { get; set; } = null!;
        public string? ADDR_TYPE { get; set; }
        public string? ADDR1 { get; set; }
        public string? ADDR2 { get; set; }
        public string? COUNTRY { get; set; }
        public string? PROVINCE { get; set; }
        public string? CITY { get; set; }
        public string? POSTAL_CODE { get; set; }
        public string? OWNERSHIP_STAT { get; set; }
        public string? PHONE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? DELBY { get; set; }
        public DateTime? DEL_DATE { get; set; }
    }
}
