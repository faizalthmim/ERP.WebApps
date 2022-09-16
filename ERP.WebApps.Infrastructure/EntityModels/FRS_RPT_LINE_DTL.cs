using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FRS_RPT_LINE_DTL
    {
        public string RPT_ID { get; set; } = null!;
        public int LINE_NO { get; set; }
        public int SEQ_NO { get; set; }
        public string? COY_FROM { get; set; }
        public string? COY_TO { get; set; }
        public string? UNTT_FROM { get; set; }
        public string? UNTT_TO { get; set; }
        public string? ACCT_NO_FROM { get; set; }
        public string? ACCT_NO_TO { get; set; }
        public int? SIGN { get; set; }
    }
}
