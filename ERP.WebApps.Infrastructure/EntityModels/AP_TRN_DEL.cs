using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class AP_TRN_DEL
    {
        public string? COY_CODE { get; set; }
        public string? AP_NO { get; set; }
        public int? TRN_SEQ { get; set; }
        public string? TRN_ACCT_NO { get; set; }
        public string? TRN_TYPE { get; set; }
        public decimal? TRN_AMT { get; set; }
        public decimal? TRN_CURR_AMT { get; set; }
        public decimal? TRN_CURR_RATE { get; set; }
        public string? PRF_NO { get; set; }
        public string? VOUCH_NO { get; set; }
        public string? VOUCH_DATE { get; set; }
        public string? TRN_DESC { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? PNL_DEL_ID { get; set; }
    }
}
