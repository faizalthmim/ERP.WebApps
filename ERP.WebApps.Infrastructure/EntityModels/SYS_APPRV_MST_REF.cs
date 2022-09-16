using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_APPRV_MST_REF
    {
        public string COY_CODE { get; set; } = null!;
        public string APPRV_DOC_TYPE { get; set; } = null!;
        public string APPRV_EMP_ID { get; set; } = null!;
        public short APPRV_LVL { get; set; }
        public short APPRV_LVL_SEQ { get; set; }
        public string? APPRV_LVL_DESC { get; set; }
        public string? APPRV_TYPE { get; set; }
        public string? APPRV_ID { get; set; }
        public string? LVL_CODE { get; set; }
        public string? POSITION { get; set; }
        public string? COND { get; set; }
        public string? QUERY { get; set; }
        public int? ESC_DAYS { get; set; }
        public int? NOT_DAYS { get; set; }
        public string? EDITABLE { get; set; }
        public string? FORWARD { get; set; }
        public bool? MANDATORY { get; set; }
    }
}
