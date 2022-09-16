using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRF_ATT_DET
    {
        public string COY_CODE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public int SEQ_NO { get; set; }
        public string? ATTCH_TYPE { get; set; }
        public string? ATTCH_DESC { get; set; }
    }
}
