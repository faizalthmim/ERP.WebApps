using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class COSTING_RPT_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string RPT_ID { get; set; } = null!;
        public string RPT_SEQ { get; set; } = null!;
        public string? RPT_DESC { get; set; }
        public string? DISPLAY_UOM { get; set; }
        public string? DISPLAY_UNIT_PRICE { get; set; }
    }
}
