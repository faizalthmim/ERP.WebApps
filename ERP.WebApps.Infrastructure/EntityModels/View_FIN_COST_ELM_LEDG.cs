using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class View_FIN_COST_ELM_LEDG
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string YEAR { get; set; } = null!;
        public string MONTH { get; set; } = null!;
        public string COST_CTR { get; set; } = null!;
        public string ACCT_NO { get; set; } = null!;
        public string COST_ELM { get; set; } = null!;
        public decimal? DR_AMT { get; set; }
        public decimal? CR_AMT { get; set; }
        public decimal? NET_AMT { get; set; }
        public decimal? BAL_AMT { get; set; }
        public decimal? BAL_QTY { get; set; }
    }
}
