using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FXA_TRN_CODE
    {
        public string TRN_GROUP { get; set; } = null!;
        public string TRN_CODE { get; set; } = null!;
        public string? TRN_DESC { get; set; }
        public string? TRN_GROUP_DESC { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
