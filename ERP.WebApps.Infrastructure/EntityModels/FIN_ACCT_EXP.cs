using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_ACCT_EXP
    {
        public string COY_CODE { get; set; } = null!;
        public string ACCT_NO { get; set; } = null!;
        public string COST_CTR { get; set; } = null!;
        public string? EFF_MONTH { get; set; }
        public string? EXP_MONTH { get; set; }
        public string? APPRV_BY { get; set; }
        public DateTime? APPRV_DATE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? BLOCK_CODE { get; set; }
    }
}
