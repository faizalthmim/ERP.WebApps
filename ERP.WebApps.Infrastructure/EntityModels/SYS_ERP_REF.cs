using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_ERP_REF
    {
        public int ID { get; set; }
        public string? COY_CODE { get; set; }
        public string? REC_TYPE { get; set; }
        public string? REC_CODE { get; set; }
        public string? UNTT { get; set; }
        public string? SHORT_DESC { get; set; }
        public string? LONG_DESC { get; set; }
        public string? GROUP_NAME { get; set; }
        public string? GROUP_CODE { get; set; }
        public string? GROUP_TYPE { get; set; }
    }
}
