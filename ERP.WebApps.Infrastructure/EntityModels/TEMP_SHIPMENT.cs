using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class TEMP_SHIPMENT
    {
        public string COY_CODE { get; set; } = null!;
        public string TRN_DATE { get; set; } = null!;
        public string PROC_MONTH { get; set; } = null!;
        public string TRN_TYPE { get; set; } = null!;
        public decimal? WMT { get; set; }
    }
}
