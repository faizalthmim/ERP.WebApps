using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class HRS_EMP_CERTIFICATE_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string EMP_NO { get; set; } = null!;
        public string? CERT_TYPE { get; set; }
        public string? CERT_NO { get; set; }
        public string? CERT_NAME { get; set; }
        public string? CERT_DATE { get; set; }
        public string? CERT_PROVIDER { get; set; }
        public string? EXPIRED_DATE { get; set; }
        public string? RESULT { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
    }
}
