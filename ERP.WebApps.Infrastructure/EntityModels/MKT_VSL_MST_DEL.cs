using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_VSL_MST_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string VSL_CODE { get; set; } = null!;
        public string? VSL_KIND { get; set; }
        public string? VSL_SUB_KIND { get; set; }
        public string? VSL_TYPE { get; set; }
        public string? VSL_NAME { get; set; }
        public string? VSL_YEAR { get; set; }
        public string? VSL_CTRY { get; set; }
        public string? VSL_PORT { get; set; }
        public string? VSL_UOM { get; set; }
        public decimal? VSL_CAP { get; set; }
        public string? CAPT_NAME { get; set; }
        public string? OWNER_NAME { get; set; }
        public string? OWNER_ADDR1 { get; set; }
        public string? OWNER_ADDR2 { get; set; }
        public string? OWNER_ADDR3 { get; set; }
        public string? OWNER_CTRY { get; set; }
        public string? OWNER_PHONE { get; set; }
        public string? OWNER_EMAIL { get; set; }
        public string? REMARK { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? DEL_TYPE { get; set; }
    }
}
