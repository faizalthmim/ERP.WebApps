using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_USER_SURR_DEL
    {
        public string? COY_CODE { get; set; }
        public string? DOC_TYPE { get; set; }
        public string FROM_USER_ID { get; set; } = null!;
        public DateTime START_DATE { get; set; }
        public string? TO_USER_ID { get; set; }
        public DateTime? END_DATE { get; set; }
        public string? REASON { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
    }
}
