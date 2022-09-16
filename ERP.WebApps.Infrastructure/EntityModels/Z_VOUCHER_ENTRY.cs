using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class Z_VOUCHER_ENTRY
    {
        public int ID { get; set; }
        public string? VCH_NO { get; set; }
        public string? VCH_TYPE { get; set; }
        public string? VCH_DATE { get; set; }
        public string? OLD_ACCT_NO { get; set; }
        public string? OLD_ACCT_NAME { get; set; }
        public string? ACCT_NO { get; set; }
        public string? COST_CTR { get; set; }
        public string? TRN_CODE { get; set; }
        public decimal? DEBIT { get; set; }
        public decimal? CREDIT { get; set; }
        public string? DESCRIPTION { get; set; }
    }
}
