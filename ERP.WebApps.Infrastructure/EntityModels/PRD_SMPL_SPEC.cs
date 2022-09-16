using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_SMPL_SPEC
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string PRDCT_CODE { get; set; } = null!;
        public string SMPL_TYPE { get; set; } = null!;
        public decimal? STD { get; set; }
        public decimal? MAX { get; set; }
        public decimal? MIN { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? UPD_BY { get; set; }
    }
}
