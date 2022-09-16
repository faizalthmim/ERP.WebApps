using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_ILT_REF
    {
        public string UNTT_SEND { get; set; } = null!;
        public string UNTT_RECV { get; set; } = null!;
        public string ACCT_NO { get; set; } = null!;
        public string? CNTR_ACCT_NO { get; set; }
    }
}
