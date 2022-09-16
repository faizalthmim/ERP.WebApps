using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class AR_MST_FC
    {
        public string COY_CODE { get; set; } = null!;
        public string AR_NO { get; set; } = null!;
        public string CURR_CODE { get; set; } = null!;
        public decimal CURR_BASIC_RATE { get; set; }
        public decimal CURR_PPN_RATE { get; set; }
        public decimal CURR_PPH_RATE { get; set; }
        public decimal CURR_BASIC_AMT { get; set; }
        public decimal CURR_PPN_AMT { get; set; }
        public decimal CURR_PPH_AMT { get; set; }
    }
}
