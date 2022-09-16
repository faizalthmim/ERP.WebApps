using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_VCH_TAKE
    {
        public string COY_CODE { get; set; } = null!;
        public string VOUCH_NO { get; set; } = null!;
        public string VOUCH_ITEM { get; set; } = null!;
        public string? VOUCH_DATE { get; set; }
        public string? CORR_VOUCH_NO { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? MODULE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
    }
}
