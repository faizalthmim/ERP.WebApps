using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_ACCT_REF
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string REC_TYPE { get; set; } = null!;
        public string VOUCH_SEQ { get; set; } = null!;
        public int STEP_NO { get; set; }
        public string ACCT_NO_IN { get; set; } = null!;
        public string? COST_CTR_IN { get; set; }
        public string ACCT_NO_OUT { get; set; } = null!;
        public string? COST_CTR_OUT { get; set; }
        public string VOUCH_REMARK { get; set; } = null!;
        public string UPD_BY { get; set; } = null!;
        public DateTime UPD_DATE { get; set; }
    }
}
