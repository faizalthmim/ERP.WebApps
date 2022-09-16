using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_APPRV_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string APPRV_DOC_TYPE { get; set; } = null!;
        public string APPRV_EMP_ID { get; set; } = null!;
        public short? APPRV_LVL { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? SPECIAL_LVL { get; set; }
    }
}
