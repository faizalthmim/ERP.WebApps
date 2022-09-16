using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class AR_MST_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public string PROC_MONTH { get; set; } = null!;
        public string AR_NO { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string REC_CODE { get; set; } = null!;
        public string REC_KIND { get; set; } = null!;
        public string PAYEE_TYPE { get; set; } = null!;
        public string PAYEE_NO { get; set; } = null!;
        public string ACCT_NO { get; set; } = null!;
        public string DOC_TYPE { get; set; } = null!;
        public string DOC_NO { get; set; } = null!;
        public string INV_NO { get; set; } = null!;
        public string PPN_ACCT_NO { get; set; } = null!;
        public string PPH_ACCT_NO { get; set; } = null!;
        public string VOUCH_NO { get; set; } = null!;
        public string VOUCH_DATE { get; set; } = null!;
        public string CURR_CODE { get; set; } = null!;
        public decimal CURR_RATE { get; set; }
        public decimal FOREIGN_AMT { get; set; }
        public decimal BASIC_AMT { get; set; }
        public decimal PPN { get; set; }
        public decimal RCV_PPN { get; set; }
        public decimal PPN_AMT { get; set; }
        public decimal PPH_AMT { get; set; }
        public decimal ADJ_AMT { get; set; }
        public decimal DISC_AMT { get; set; }
        public decimal RCV_AMT { get; set; }
        public string SETTLE_BY { get; set; } = null!;
        public DateTime? SETTLE_DATE { get; set; }
        public string INV_DATE { get; set; } = null!;
        public string DUE_DATE { get; set; } = null!;
        public decimal QTY_TON { get; set; }
        public string CRE_BY { get; set; } = null!;
        public DateTime? CRE_DATE { get; set; }
        public string UPD_BY { get; set; } = null!;
        public DateTime? UPD_DATE { get; set; }
        public string PNL_UPD_ID { get; set; } = null!;
        public decimal C_TOT_AR_AMT { get; set; }
        public string DEL_BY { get; set; } = null!;
        public DateTime? DEL_DATE { get; set; }
        public string DEL_TYPE { get; set; } = null!;
    }
}
