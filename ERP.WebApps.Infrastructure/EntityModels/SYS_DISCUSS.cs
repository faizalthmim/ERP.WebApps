using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_DISCUSS
    {
        public string COY_CODE { get; set; } = null!;
        public string DISCUSS_ID { get; set; } = null!;
        public string DOC_TYPE { get; set; } = null!;
        public string DOC_NO { get; set; } = null!;
        public string DISCUSS_DATE { get; set; } = null!;
        public string DISCUSS_DESC { get; set; } = null!;
        public string NOTIFY_ID { get; set; } = null!;
        public string? CLOSE_BY { get; set; }
        public DateTime? CLOSE_DATE { get; set; }
        public string STAT_CODE { get; set; } = null!;
        public string CRE_BY { get; set; } = null!;
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
