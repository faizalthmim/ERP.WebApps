using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_BDGT_RVSD_TRN
    {
        public string COY_CODE { get; set; } = null!;
        public string PRDCT_CODE { get; set; } = null!;
        public string PROD_DATE { get; set; } = null!;
        public int PROC_MONTH { get; set; }
        public decimal BDGT_QTY { get; set; }
        public decimal REVISED_QTY { get; set; }
        public decimal? FIN_QTY { get; set; }
        public string FORM_NO { get; set; } = null!;
    }
}
