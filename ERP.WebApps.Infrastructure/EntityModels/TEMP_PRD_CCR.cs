using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class TEMP_PRD_CCR
    {
        public string COY_CODE { get; set; } = null!;
        public string TRN_PROD { get; set; } = null!;
        public string? PROC_MONTH { get; set; }
        public decimal? CRH_PROD { get; set; }
        public decimal? BPP_PROD { get; set; }
        public decimal? MOIS { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
