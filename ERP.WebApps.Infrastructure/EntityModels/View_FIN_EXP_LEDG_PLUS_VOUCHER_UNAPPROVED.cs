using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class View_FIN_EXP_LEDG_PLUS_VOUCHER_UNAPPROVED
    {
        public string COY_CODE { get; set; } = null!;
        public string? UNTT { get; set; }
        public string? YEAR { get; set; }
        public string? MONTH { get; set; }
        public string? ACCT_NO { get; set; }
        public string? COST_CTR { get; set; }
        public decimal? DR_AMT { get; set; }
        public decimal? CR_AMT { get; set; }
        public decimal? NET_AMT { get; set; }
        public decimal? BAL_AMT { get; set; }
        public decimal? BAL_QTY { get; set; }
        public decimal? BUDG_AMT { get; set; }
        public decimal? BUDG_QTY { get; set; }
    }
}
