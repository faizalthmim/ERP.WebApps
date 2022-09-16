using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_CRTFY_TRN
    {
        public string COY_CODE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public string PROC_STG_CODE { get; set; } = null!;
        public string PROD_DATE { get; set; } = null!;
        public int START_HOUR { get; set; }
        public int END_HOUR { get; set; }
        public decimal? QTY { get; set; }
    }
}
