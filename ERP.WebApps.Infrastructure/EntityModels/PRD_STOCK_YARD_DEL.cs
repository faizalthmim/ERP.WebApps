using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_STOCK_YARD_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string PRDCT_CODE { get; set; } = null!;
        public int PROC_MONTH { get; set; }
        public string? PROD_DATE_INPUT { get; set; }
        public decimal? WEST_BELOW { get; set; }
        public decimal? WEST_LOAD { get; set; }
        public decimal? EAST_BELOW { get; set; }
        public decimal? EAST_LOAD { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? PGM_ID { get; set; }
    }
}
