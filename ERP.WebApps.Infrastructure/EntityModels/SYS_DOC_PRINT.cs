using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_DOC_PRINT
    {
        public string COY_CODE { get; set; } = null!;
        public string DOC_TYPE { get; set; } = null!;
        public string DOC_NO { get; set; } = null!;
        public int? SEQ { get; set; }
        public string? LAST_PRINT_BY { get; set; }
        public string? LAST_PRINT_DATE { get; set; }
    }
}
