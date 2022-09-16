using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_ACCT_REF
    {
        public string COY_CODE { get; set; } = null!;
        public string ITEM_NO { get; set; } = null!;
        public string? INV_ACCT_NO { get; set; }
        public string? INV_IN_TRANSIT_ACCT_NO { get; set; }
        public string? EXP_ACCT_NO { get; set; }
    }
}
