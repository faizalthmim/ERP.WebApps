using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_MDO
    {
        public string COY_CODE { get; set; } = null!;
        public string MDO_NO { get; set; } = null!;
        public string? SALES_TYPE { get; set; }
        public string? ORDER_TYPE { get; set; }
        public string? MDO_TYPE { get; set; }
        public string? CUST_CODE { get; set; }
        public string? DELV_ADD1 { get; set; }
        public string? DELV_ADD2 { get; set; }
        public string? DELV_ADD3 { get; set; }
        public string? DELV_CTRY { get; set; }
        public string? DPCH_LOCT { get; set; }
        public string? OPEN_DATE { get; set; }
        public string? EXP_DATE { get; set; }
        public string? FRGHT_TYPE { get; set; }
        public string? PROD_TYPE { get; set; }
        public string? PACK_CODE { get; set; }
        public string? BRAND_CODE { get; set; }
        public string? BAG_TYPE { get; set; }
        public decimal? QTY_BAG { get; set; }
        public decimal? QTY_TON { get; set; }
        public decimal? QTY_OTW { get; set; }
        public decimal? QTY_DELV { get; set; }
        public string? UOM { get; set; }
        public string? CURR_CODE { get; set; }
        public decimal? PRICE { get; set; }
        public decimal? PRICE_DIST { get; set; }
        public string? PAY_TYPE { get; set; }
        public int? PAY_TERM { get; set; }
        public string? STAT_CODE { get; set; }
        public string? REMARK { get; set; }
        public string? CONTRACT_NO { get; set; }
        public string? DOC_TYPE { get; set; }
        public string? DOC_NO { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public decimal? C_QTY_OUTS_TON { get; set; }
    }
}
