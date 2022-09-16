using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class View_PRF_ADV_Voucher
    {
        public string coy_code { get; set; } = null!;
        public string form_no { get; set; } = null!;
        public string? vouch_No { get; set; }
    }
}
