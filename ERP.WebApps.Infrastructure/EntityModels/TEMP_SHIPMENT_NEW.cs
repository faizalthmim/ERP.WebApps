using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class TEMP_SHIPMENT_NEW
    {
        public string COY_CODE { get; set; } = null!;
        public string TRN_DATE { get; set; } = null!;
        public string PROC_MONTH { get; set; } = null!;
        public decimal? BDGT_QTY { get; set; }
        public decimal? ACTUAL_QTY { get; set; }
        public decimal? REVISED_QTY { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
