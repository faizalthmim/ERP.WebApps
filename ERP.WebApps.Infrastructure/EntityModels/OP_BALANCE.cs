using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class OP_BALANCE
    {
        public string COY_CODE { get; set; } = null!;
        public string ACCT_NO { get; set; } = null!;
        public string? DESCRIPTION { get; set; }
        public decimal? DEBIT { get; set; }
        public decimal? CREDIT { get; set; }
        public string? VOUCH_DATE { get; set; }
        public string? ERR_DESC { get; set; }
    }
}
