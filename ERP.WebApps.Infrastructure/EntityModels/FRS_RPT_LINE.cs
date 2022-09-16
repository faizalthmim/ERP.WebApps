using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FRS_RPT_LINE
    {
        public string RPT_ID { get; set; } = null!;
        public int LINE_NO { get; set; }
        public string? LINE_TEXT { get; set; }
        public string? OTHER_TEXT { get; set; }
        public short? LINE_TYPE { get; set; }
        public bool? BOLD_FLAG { get; set; }
        public int? NATURE { get; set; }
        public bool? HIDE_WHEN_ZERO { get; set; }
    }
}
