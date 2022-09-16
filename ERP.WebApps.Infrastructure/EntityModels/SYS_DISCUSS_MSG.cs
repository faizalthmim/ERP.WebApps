using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_DISCUSS_MSG
    {
        public string COY_CODE { get; set; } = null!;
        public string DISCUSS_ID { get; set; } = null!;
        public long MSG_ID { get; set; }
        public string MSG { get; set; } = null!;
        public string? SPECIAL_ID { get; set; }
        public string? REPLY_MSG_ID { get; set; }
        public DateTime? REPLY_MSG_DATE { get; set; }
        public string? STAT_CODE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? DEL_TYPE { get; set; }
        public string CRE_BY { get; set; } = null!;
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
