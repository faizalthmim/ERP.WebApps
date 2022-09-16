using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_ERP_MSG
    {
        public int ID { get; set; }
        public string? COY_CODE { get; set; }
        public string? MSG_TYPE { get; set; }
        public string? START_DATE { get; set; }
        public string? END_DATE { get; set; }
        public string? START_BLOCK_DATE { get; set; }
        public string? END_BLOCK_DATE { get; set; }
        public string? SHORT_DESC { get; set; }
        public string? LONG_DESC { get; set; }
        public string? STATUS { get; set; }
    }
}
