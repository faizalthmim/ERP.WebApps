using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_BDGT_YRLY_TRN_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string? PRDCT_CODE { get; set; }
        public string PROD_DATE { get; set; } = null!;
        public int PROC_MONTH { get; set; }
        public decimal? BDGT_QTY { get; set; }
        public decimal? REVISED_QTY { get; set; }
        public decimal? ACTUAL_QTY { get; set; }
        public decimal? FIN_QTY { get; set; }
        public string FORM_NO { get; set; } = null!;
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? PGM_ID { get; set; }
    }
}
