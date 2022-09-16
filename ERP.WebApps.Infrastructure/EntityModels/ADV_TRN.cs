using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class ADV_TRN
    {
        public string COY_CODE { get; set; } = null!;
        public string TYPE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public short SEQ_NO { get; set; }
        public string? TRN_DTL { get; set; }
        public string? CURR { get; set; }
        public string? ACCT_NO { get; set; }
        public decimal? TRN_AMT { get; set; }
        public decimal? CURR_RATE { get; set; }
        public decimal? VAT_AMT { get; set; }
        public string? PPH_FLAG { get; set; }
        public decimal? IDR_TRN_AMT { get; set; }
    }
}
