using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_VCH_RMK_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string VOUCH_NO { get; set; } = null!;
        public string CNCL_CNTR { get; set; } = null!;
        public string? PAYEE_TYPE { get; set; }
        public string? PAYEE_NO { get; set; }
        public string? PAYEE_NAME { get; set; }
        public string? CHEQUE_NO { get; set; }
        public string? VOUCH_BANK { get; set; }
        public string? RECEIVE_BY { get; set; }
        public string? DUE_DATE { get; set; }
        public string? REMARKS { get; set; }
        public string? PGM_ID { get; set; }
        public string? CNCL_BY { get; set; }
        public DateTime? CNCL_TIME { get; set; }
        public string? ACTV_BY { get; set; }
        public DateTime? ACTV_TIME { get; set; }
        public string? CHECKED_BY { get; set; }
        public DateTime? CHECKED_DATE { get; set; }
        public string? APPRV_BY { get; set; }
        public DateTime? APPRV_DATE { get; set; }
        public string? REV_STAT { get; set; }
    }
}
