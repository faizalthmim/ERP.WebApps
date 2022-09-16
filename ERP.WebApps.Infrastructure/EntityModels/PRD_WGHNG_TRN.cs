using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_WGHNG_TRN
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PROD_NO { get; set; } = null!;
        public string? MCHN_CODE { get; set; }
        public string DPCH_NO { get; set; } = null!;
        public string VHC_NO { get; set; } = null!;
        public string? VHC_KIND { get; set; }
        public string? VHC_TYPE { get; set; }
        public string PRDCT_TYPE { get; set; } = null!;
        public string? MINING_SITE { get; set; }
        public string? DRIVER_ID { get; set; }
        public string? DRIVER_NAME { get; set; }
        public string? PO_NO { get; set; }
        public decimal? NET_WEIGHT { get; set; }
        public decimal? GROSS_WEIGHT { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? UPD_BY { get; set; }
    }
}
