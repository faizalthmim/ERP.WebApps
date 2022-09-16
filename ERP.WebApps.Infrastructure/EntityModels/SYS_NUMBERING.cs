using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_NUMBERING
    {
        public string COY_CODE { get; set; } = null!;
        public string APP_CODE { get; set; } = null!;
        public string KEY_CODE { get; set; } = null!;
        public int SEQ_NO { get; set; }
        public DateTime? LAST_USED { get; set; }
    }
}
