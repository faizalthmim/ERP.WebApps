using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FXA_FA_CTGR
    {
        public string KIND_NO { get; set; } = null!;
        public string SUB_KIND_NO { get; set; } = null!;
        public string? KIND_DESC { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? ACCT_NO { get; set; }
        public string? BLOCK_CODE { get; set; }
    }
}
