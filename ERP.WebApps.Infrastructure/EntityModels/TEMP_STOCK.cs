using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class TEMP_STOCK
    {
        public string COY_CODE { get; set; } = null!;
        public string STOCK_DATE { get; set; } = null!;
        public string PROD_TYPE { get; set; } = null!;
        public decimal? BLW_KT { get; set; }
        public decimal? ACT_KT { get; set; }
        public string? TRN_DATE { get; set; }
    }
}
