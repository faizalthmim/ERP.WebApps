using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_CAL_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string CAL_DATE { get; set; } = null!;
        public byte? WEEK_IN_YEAR { get; set; }
        public short? DAY_IN_YEAR { get; set; }
        public byte? DAY_IN_WEEK { get; set; }
        public string? HOLY_CODE { get; set; }
        public string? DAY_NAME { get; set; }
        public string? REMK { get; set; }
    }
}
