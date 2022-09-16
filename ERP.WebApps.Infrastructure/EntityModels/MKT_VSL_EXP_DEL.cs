using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_VSL_EXP_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string SDO_NO { get; set; } = null!;
        public string EXP_TYPE { get; set; } = null!;
        public string? VSL_CODE { get; set; }
        public string? VOYG_NO { get; set; }
        public string? FORM_NO { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? DEL_TYPE { get; set; }
    }
}
