using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FRS_RPT_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string RPT_NAME { get; set; } = null!;
        public string? RPT_ID { get; set; }
        public string? RPT_HEADER { get; set; }
    }
}
