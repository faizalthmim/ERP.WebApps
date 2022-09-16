using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_ROLE_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string DOC_TYPE { get; set; } = null!;
        public string ROLE { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
    }
}
