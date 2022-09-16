using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_USER_SURR
    {
        public string COY_CODE { get; set; } = null!;
        public string DOC_TYPE { get; set; } = null!;
        public string FROM_USER_ID { get; set; } = null!;
        public DateTime START_DATE { get; set; }
        public string? TO_USER_ID { get; set; }
        public DateTime? END_DATE { get; set; }
        public string? REASON { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
