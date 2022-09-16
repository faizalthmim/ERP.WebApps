using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class Z_CAD_ADV_EXP
    {
        public string COY_CODE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public int SEQ_NO { get; set; }
        public string? DETAILS { get; set; }
        public decimal? EXP_AMT { get; set; }
        public string? CURR_CODE { get; set; }
        public decimal? CURR_RATE { get; set; }
        public decimal? IDR__EXP_AMT { get; set; }
    }
}
