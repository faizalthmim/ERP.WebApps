using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_DOC_ATTCH
    {
        public string COY_CODE { get; set; } = null!;
        public string DOC_TYPE { get; set; } = null!;
        public string DOC_NO { get; set; } = null!;
        public string ATTCH_NAME { get; set; } = null!;
        public string ATTCH_EXT { get; set; } = null!;
        public string? ATTCH_SIZE { get; set; }
        public string? ATTCH_CONTENT_TYPE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? FLAG { get; set; }
    }
}
