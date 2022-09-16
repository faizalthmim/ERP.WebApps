using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FXA_ACCT_REF
    {
        public string COY_CODE { get; set; } = null!;
        public string ACCT_NO { get; set; } = null!;
        public string? ACCT_NO_CR { get; set; }
        public string? ACCT_NO_DR_PROD { get; set; }
        public string? ACCT_NO_DR_SUPP { get; set; }
        public string? CIP_PREOPS_CTGR { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
