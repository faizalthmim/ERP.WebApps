using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_VCH_RMK
    {
        public string COY_CODE { get; set; } = null!;
        public string VOUCH_NO { get; set; } = null!;
        public string? PAYEE_TYPE { get; set; }
        public string? PAYEE_NO { get; set; }
        public string? PAYEE_NAME { get; set; }
        public string? CHEQUE_NO { get; set; }
        public string? VOUCH_BANK { get; set; }
        public string? RECEIVE_BY { get; set; }
        public string? DUE_DATE { get; set; }
        public string? REMARKS { get; set; }
        public string? PGM_ID { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? CHECKED_BY { get; set; }
        public DateTime? CHECKED_DATE { get; set; }
        public string? APPRV_BY { get; set; }
        public DateTime? APPRV_DATE { get; set; }
        public string? REV_STAT { get; set; }
    }
}
