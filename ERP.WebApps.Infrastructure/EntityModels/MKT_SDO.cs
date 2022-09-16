using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_SDO
    {
        public string COY_CODE { get; set; } = null!;
        public string SDO_NO { get; set; } = null!;
        public string? VSL_CODE { get; set; }
        public string? VOYG_NO { get; set; }
        public string? MDO_NO { get; set; }
        public string? SDO_DATE { get; set; }
        public string? XDELV_DATE { get; set; }
        public string? CUST_CODE { get; set; }
        public string? PROD_TYPE { get; set; }
        public string? PACK_CODE { get; set; }
        public string? BRAND_CODE { get; set; }
        public string? BAG_TYPE { get; set; }
        public string? PORT_CODE { get; set; }
        public string? DELV_ADD1 { get; set; }
        public string? DELV_ADD2 { get; set; }
        public string? DELV_ADD3 { get; set; }
        public string? DELV_CTRY { get; set; }
        public string? QTY_UOM { get; set; }
        public decimal? EST_QTY { get; set; }
        public decimal? ACD_QTY { get; set; }
        public decimal? ACW_QTY { get; set; }
        public long? PRC_ID { get; set; }
        public string? CURR_CODE { get; set; }
        public decimal? PRICE { get; set; }
        public decimal? PRICE_DIST { get; set; }
        public string? DOC_QLT_NO { get; set; }
        public string? INV_NO { get; set; }
        public string? REMARK { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
