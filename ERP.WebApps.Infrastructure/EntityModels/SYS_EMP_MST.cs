using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_EMP_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string EMP_NO { get; set; } = null!;
        public string? EMP_NAME { get; set; }
        public string? UNTT { get; set; }
        public string? PLAN_CODE { get; set; }
        public string? WORK_PLAN_CODE { get; set; }
        public string? DEPT_CODE { get; set; }
        public string? JOB_CODE { get; set; }
        public string? ECHELON { get; set; }
        public string? GRADE { get; set; }
        public string? SERV_CODE { get; set; }
        public string? EMAIL { get; set; }
        public string? MOBILE_PHONE { get; set; }
        public string? SERV_DATE { get; set; }
        public string? CONTRACT_DATE { get; set; }
        public string? RESIGN_DATE { get; set; }
        public string? BANK_AC_NO { get; set; }
        public string? BANK_AC_NAME { get; set; }
        public string? BANK_NAME { get; set; }
        public string? GENDER { get; set; }
        public string? FLG_LEAVE { get; set; }
        public string? HR_EMP_NO { get; set; }
        public string? UPD_BY { get; set; }
        public string? UPD_DATE { get; set; }
    }
}
