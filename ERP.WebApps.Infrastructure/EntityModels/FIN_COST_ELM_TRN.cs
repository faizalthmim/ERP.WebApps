using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_COST_ELM_TRN
    {
        public int ID { get; set; }
        public string? COY_CODE { get; set; }
        public string? UNTT { get; set; }
        public string? YEAR { get; set; }
        public string? MONTH { get; set; }
        public string? REC_CODE { get; set; }
        public string? COST_CTR_IN { get; set; }
        public string? ACCT_NO_IN { get; set; }
        public string? COST_ELM { get; set; }
        public string? COST_CTR_OUT { get; set; }
        public string? ACCT_NO_OUT { get; set; }
        public decimal? QTY { get; set; }
        public decimal? AMT { get; set; }
        public decimal? UNIT_PRICE { get; set; }
        public string? VOUCH_NO { get; set; }
        public string? VOUCH_ITEM { get; set; }
        public string? VOUCH_STAT { get; set; }
    }
}
