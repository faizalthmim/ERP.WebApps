using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_CURR_MST
    {
        public string CURR_CODE { get; set; } = null!;
        public string? CURR_NAME { get; set; }
        public string? DISP_ORDER { get; set; }
        public string? INPUT_RATE { get; set; }
    }
}
