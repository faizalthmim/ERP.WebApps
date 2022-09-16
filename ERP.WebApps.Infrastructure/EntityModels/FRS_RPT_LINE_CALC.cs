using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FRS_RPT_LINE_CALC
    {
        public string RPT_ID { get; set; } = null!;
        public int LINE_NO { get; set; }
        public int SEQ_NO { get; set; }
        public string? OP { get; set; }
        public int? OP_LINE_NO { get; set; }
    }
}
