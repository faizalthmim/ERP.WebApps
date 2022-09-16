using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_CLOSING_ADM
    {
        public string COY_CODE { get; set; } = null!;
        public string MODULE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string CLOSE_MONTH { get; set; } = null!;
        public short CLOSE_SEQ { get; set; }
        public string? STATUS { get; set; }
        public string? CLOSE_BY { get; set; }
        public string? REMARK { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
    }
}
