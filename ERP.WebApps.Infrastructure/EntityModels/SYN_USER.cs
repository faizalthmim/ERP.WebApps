using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYN_USER
    {
        public string USER_ID { get; set; } = null!;
        public string? USER_NAME { get; set; }
        public string? PWD { get; set; }
        public byte? USER_TYPE { get; set; }
        public byte? BLOCK_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
