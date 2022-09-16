using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_APPL_START
    {
        public int ID { get; set; }
        public string? USER_ID { get; set; }
        public string? COY_CODE { get; set; }
        public string? PGM_ID { get; set; }
    }
}
