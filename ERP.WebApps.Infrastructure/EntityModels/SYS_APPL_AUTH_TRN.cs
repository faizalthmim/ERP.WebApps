using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_APPL_AUTH_TRN
    {
        public string USER_ID { get; set; } = null!;
        public string COY_CODE { get; set; } = null!;
        public string PGM_ID { get; set; } = null!;
        public byte? BLOCK_CODE { get; set; }
    }
}
