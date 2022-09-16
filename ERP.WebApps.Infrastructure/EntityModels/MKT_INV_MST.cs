using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_INV_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string INV_NO { get; set; } = null!;
        public string INV_FAKTUR { get; set; } = null!;
        public string INV_DATE { get; set; } = null!;
        public string SDO_NO { get; set; } = null!;
        public string CUST_CODE { get; set; } = null!;
        public string SALES_TYPE { get; set; } = null!;
        public string ORDER_TYPE { get; set; } = null!;
        public string DELV_DATE { get; set; } = null!;
        public string PROD_TYPE { get; set; } = null!;
        public string PACK_CODE { get; set; } = null!;
        public string BRAND_CODE { get; set; } = null!;
        public string BAG_TYPE { get; set; } = null!;
        public string PORT_CODE { get; set; } = null!;
        public string DELV_ADD1 { get; set; } = null!;
        public string DELV_ADD2 { get; set; } = null!;
        public string DELV_ADD3 { get; set; } = null!;
        public string DELV_CTRY { get; set; } = null!;
        public string QTY_UOM { get; set; } = null!;
        public decimal ACW_QTY { get; set; }
        public decimal ACD_QTY { get; set; }
        public long PRC_ID { get; set; }
        public string CURR_CODE { get; set; } = null!;
        public decimal PRICE { get; set; }
        public decimal PRICE_DIST { get; set; }
        public decimal BASC_AMT { get; set; }
        public decimal ADJ_AMT { get; set; }
        public decimal DISC_AMT { get; set; }
        public decimal PPN_AMT { get; set; }
        public decimal PPH_AMT { get; set; }
        public decimal? INV_AMT { get; set; }
        public decimal CURR_RATE { get; set; }
        public decimal? CURR_PPN_RATE { get; set; }
        public decimal? CURR_PPH_RATE { get; set; }
        public decimal? BASC_AMT_IDR { get; set; }
        public decimal? ADJ_AMT_IDR { get; set; }
        public decimal? DISC_AMT_IDR { get; set; }
        public decimal? PPN_AMT_IDR { get; set; }
        public decimal? PPH_AMT_IDR { get; set; }
        public decimal? INV_AMT_IDR { get; set; }
        public int INVO_DATE { get; set; }
        public int INVO_PERD { get; set; }
        public string PAY_TYPE { get; set; } = null!;
        public int PAY_TERM { get; set; }
        public string DUE_DATE { get; set; } = null!;
        public string PAY_COND { get; set; } = null!;
        public string AR_POST_BY { get; set; } = null!;
        public string AR_POST_DATE { get; set; } = null!;
        public string AR_POST_TIME { get; set; } = null!;
        public string AR_ACCT_NO { get; set; } = null!;
        public string PPN_ACCT_NO { get; set; } = null!;
        public string PPH_ACCT_NO { get; set; } = null!;
        public string DOC_NO { get; set; } = null!;
        public string VOUCH_NO { get; set; } = null!;
        public bool? AUTO_VCH { get; set; }
        public string? REMARK { get; set; }
        public string CRE_BY { get; set; } = null!;
        public DateTime? CRE_DATE { get; set; }
        public string UPD_BY { get; set; } = null!;
        public DateTime? UPD_DATE { get; set; }
        public string PRINT_BY { get; set; } = null!;
        public DateTime? PRINT_DATE { get; set; }
        public string PRINT_FAKTUR_BY { get; set; } = null!;
        public DateTime? PRINT_FAKTUR_DATE { get; set; }
        public string STAT_CODE { get; set; } = null!;
    }
}
