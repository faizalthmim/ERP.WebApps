using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_VCH_ILT
    {
        public string COY_CODE { get; set; } = null!;
        public string YEAR { get; set; } = null!;
        public string MONTH { get; set; } = null!;
        public string VOUCH_NO { get; set; } = null!;
        public string ILT_SEQ { get; set; } = null!;
        public string? UNTT { get; set; }
        public string? ACCT_NO { get; set; }
        public string? VOUCH_DATE { get; set; }
        public decimal? DR_AMT { get; set; }
        public decimal? CR_AMT { get; set; }
        public decimal? DR_QTY { get; set; }
        public decimal? CR_QTY { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? CORR_VOUCH_NO { get; set; }
        public string? COMPLETE_BY { get; set; }
        public DateTime? COMPLETE_TIME { get; set; }
    }
}
