using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class HRS_EMP_PERSONAL_INFO
    {
        public string COY_CODE { get; set; } = null!;
        public string EMP_NO { get; set; } = null!;
        public string? NATIONALITY { get; set; }
        public string? PLACE_OF_BIRTH { get; set; }
        public string? DATE_OF_BIRTH { get; set; }
        public string? RELIGION { get; set; }
        public string? MARITAL_STATUS { get; set; }
        public string? ID_TYPE { get; set; }
        public string? ID_NO { get; set; }
        public string? NPWP_NO { get; set; }
        public string? BPJS_NO { get; set; }
        public string? BPJSTK_NO { get; set; }
        public int? HEIGHT { get; set; }
        public int? WEIGHT { get; set; }
        public string? BLOOD_TYPE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
