using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_PAYEE_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string PAYEE_NO { get; set; } = null!;
        public string PAYEE_TYPE { get; set; } = null!;
        public string ACTIVE_CODE { get; set; } = null!;
        public string? PAYEE_NAME { get; set; }
        public string? PAYEE_ADDR1 { get; set; }
        public string? PAYEE_ADDR2 { get; set; }
        public string? PAYEE_ADDR3 { get; set; }
        public string? CITY_CODE { get; set; }
        public string? CTRY_CODE { get; set; }
        public string? ZIP_CODE { get; set; }
        public string? PAYEE_PHONE1 { get; set; }
        public string? PAYEE_PHONE2 { get; set; }
        public string? PAYEE_FAX { get; set; }
        public string? PAYEE_TELEX { get; set; }
        public string? EMAIL1 { get; set; }
        public string? EMAIL2 { get; set; }
        public string? EMAIL3 { get; set; }
        public string? MOBILE_NO1 { get; set; }
        public string? MOBILE_NO2 { get; set; }
        public string? MOBILE_NO3 { get; set; }
        public string? CONT_PERS_NM1 { get; set; }
        public string? CONT_PERS_NM2 { get; set; }
        public string? CONT_PERS_NM3 { get; set; }
        public string? BANK_AC_NO { get; set; }
        public string? BANK_AC_NAME { get; set; }
        public string? BANK_NAME { get; set; }
        public string? CURR_CODE { get; set; }
        public string? REMARK { get; set; }
        public string? NPWP_NO { get; set; }
        public string? PKP_NO { get; set; }
        public string? BELONG_TO { get; set; }
        public string? DEST_CODE { get; set; }
        public bool? IS_SUPPLIER { get; set; }
        public bool? IS_DISTRIBUTOR { get; set; }
        public bool? IS_SHOP { get; set; }
        public bool? IS_TRANSPORTER { get; set; }
        public bool? IS_WAREHOUSE { get; set; }
        public bool? IS_PROJECT { get; set; }
        public bool? IS_VENDOR_PROJECT { get; set; }
        public bool? IS_RAW_MAT_TRANSPORTER { get; set; }
        public string? SFA_NO { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
