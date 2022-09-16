using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class AP_MST_FC_DEL
    {
        public string? COY_CODE { get; set; }
        public string? AP_NO { get; set; }
        public string? CURR_CODE { get; set; }
        public decimal? CURR_BASIC_RATE { get; set; }
        public decimal? CURR_PPN_RATE { get; set; }
        public decimal? CURR_PPH_RATE { get; set; }
        public decimal? CURR_BASIC_AMT { get; set; }
        public decimal? CURR_PPN_AMT { get; set; }
        public decimal? CURR_PPH_AMT { get; set; }
        public decimal? CURR_AP_AMT_NOT_YET_INVOICED { get; set; }
        public decimal? CURR_AP_AMT_INVOICED { get; set; }
        public decimal? CURR_ADJ_AMT_AP_NOT_YET_INVOICED { get; set; }
        public decimal? CURR_ADJ_AMT_AP_INVOICED { get; set; }
        public decimal? CURR_PAY_AMT_AP_NOT_YET_INVOICED { get; set; }
        public decimal? CURR_PAY_AMT_AP_INVOICED { get; set; }
        public decimal? C_CURR_BAL_AMT_AP_NOT_YET_INVOICED { get; set; }
        public decimal? C_CURR_BAL_AMT_AP_INVOICED { get; set; }
    }
}
