using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class HRS_EMP_EDUCATION
    {
        public string COY_CODE { get; set; } = null!;
        public string EMP_NO { get; set; } = null!;
        public string? EDU_LEVEL { get; set; }
        public string? EDU_ENTITY { get; set; }
        public string? SUBJECT { get; set; }
        public string? FROM_YEAR { get; set; }
        public string? TO_YEAR { get; set; }
        public string? GRADUATION_DATE { get; set; }
        public string? FINAL_SCORE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
