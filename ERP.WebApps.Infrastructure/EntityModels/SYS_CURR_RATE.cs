using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_CURR_RATE
    {
        public string COY_CODE { get; set; } = null!;
        public string CURR_DATE { get; set; } = null!;
        public string CURR_CODE { get; set; } = null!;
        public decimal? CURR_RATE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
