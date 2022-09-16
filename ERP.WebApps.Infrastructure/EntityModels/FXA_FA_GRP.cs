using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FXA_FA_GRP
    {
        public string GROUP_TYPE { get; set; } = null!;
        public string GROUP_CODE { get; set; } = null!;
        public string? GROUP_TITLE { get; set; }
        public decimal? LIFE_YEAR { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
