using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_DOC_APPRV_DET
    {
        public string COY_CODE { get; set; } = null!;
        public string DOC_TYPE { get; set; } = null!;
        public string DOC_NO { get; set; } = null!;
        public long SEQ_NO { get; set; }
        public short? APPRV_LVL { get; set; }
        public short? APPRV_LVL_SEQ { get; set; }
        public string? APPRV_TASK { get; set; }
        public string? APPRV_ID { get; set; }
        public string? APPRV_DATE { get; set; }
        public string? PERSON_LVL { get; set; }
        public string? LVL_NAME { get; set; }
        public string? REMARK { get; set; }
        public string? SURR_FROM { get; set; }
        public string? ROLE { get; set; }
    }
}
