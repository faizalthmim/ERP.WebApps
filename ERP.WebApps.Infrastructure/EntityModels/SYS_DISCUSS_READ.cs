using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_DISCUSS_READ
    {
        public string COY_CODE { get; set; } = null!;
        public string DISCUSS_ID { get; set; } = null!;
        public string READ_ID { get; set; } = null!;
        public string CRE_BY { get; set; } = null!;
        public DateTime? CRE_DATE { get; set; }
    }
}
