using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_VHC_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string VHC_NO { get; set; } = null!;
        public string? TRNP_CODE { get; set; }
        public string? VHC_KIND { get; set; }
        public string? VHC_SUB_KIND { get; set; }
        public string? VHC_TYPE { get; set; }
        public string? VHC_NAME { get; set; }
        public string? VHC_YEAR { get; set; }
        public decimal? VHC_CAP { get; set; }
        public decimal? VHC_EMPTY_WGHT { get; set; }
        public string? REMARK { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
