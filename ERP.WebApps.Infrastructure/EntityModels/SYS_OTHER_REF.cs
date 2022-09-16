using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_OTHER_REF
    {
        public int ID { get; set; }
        public string? COY_CODE { get; set; }
        public string? REC_TYPE { get; set; }
        public string? UNTT { get; set; }
        public string? REC_CODE { get; set; }
        public string? REC_KIND { get; set; }
        public string? REC_TITLE { get; set; }
        public string? ACCT_NO_1 { get; set; }
        public string? ACCT_NO_2 { get; set; }
        public string? BLOCK_STATUS { get; set; }
        public string? ALLOW_MANUAL_ENTRY { get; set; }
    }
}
