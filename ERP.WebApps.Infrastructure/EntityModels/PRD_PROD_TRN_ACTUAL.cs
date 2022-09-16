using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_PROD_TRN_ACTUAL
    {
        public string COY_CODE { get; set; } = null!;
        public string PRDCT_CODE { get; set; } = null!;
        public string PROD_DATE { get; set; } = null!;
        public int PROC_MONTH { get; set; }
        public decimal? CCR_QTY { get; set; }
        public decimal? ACTUAL_QTY { get; set; }
        public decimal? MOIST { get; set; }
        public decimal? DIFFERENCE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
