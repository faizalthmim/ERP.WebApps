using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_GRP_COA
    {
        public string ACCT_NO { get; set; } = null!;
        public string? ACCT_TITLE { get; set; }
        public string? ACCT_NATURE { get; set; }
        public string? EXPN_ACCT { get; set; }
        public string? ACCT_GROUP_1 { get; set; }
        public string? ACCT_GROUP_2 { get; set; }
        public string? ACCT_GROUP_3 { get; set; }
        public string? EFF_MONTH { get; set; }
        public string? EXP_MONTH { get; set; }
        public string? TAX_STAT { get; set; }
        public string? APPRV_BY { get; set; }
        public DateTime? APPRV_DATE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? ACCT_STAT { get; set; }
        public string? OLD_CODE { get; set; }
        public string? ACCT_TYPE { get; set; }
        public string? BLOCK_CODE { get; set; }
        public string C_LVL { get; set; } = null!;
    }
}
