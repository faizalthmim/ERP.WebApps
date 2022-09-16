using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_WAREHOUSE
    {
        public string COY_CODE { get; set; } = null!;
        public string WH_CODE { get; set; } = null!;
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? WH_DESCRIPTION { get; set; }
        public string? ADDR_1 { get; set; }
        public string? ADDR_2 { get; set; }
        public string? ADDR_3 { get; set; }
        public string? PHONE { get; set; }
    }
}
