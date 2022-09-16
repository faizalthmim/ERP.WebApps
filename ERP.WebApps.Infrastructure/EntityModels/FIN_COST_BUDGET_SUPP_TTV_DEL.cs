using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_COST_BUDGET_SUPP_TTV_DEL
    {
        public string COY_CODE { get; set; } = null!;
        public long BUDG_ID { get; set; }
        public string UNTT { get; set; } = null!;
        public string YEAR { get; set; } = null!;
        public string ACCT_NO { get; set; } = null!;
        public string COST_CTR { get; set; } = null!;
        public short? ITEM_IDX { get; set; }
        public string? ITEM_DESC { get; set; }
        public string? CURR_CODE { get; set; }
        public decimal? PRICE { get; set; }
        public string? UOM { get; set; }
        public decimal? QTY { get; set; }
        public decimal? TOTAL_MONTH { get; set; }
        public decimal? FREQ { get; set; }
        public decimal? TOTAL_YEAR { get; set; }
        public string? REMARK { get; set; }
        public string? REMARK_2 { get; set; }
        public string? FILE_NAME { get; set; }
        public string? DOC_DATE { get; set; }
        public string? DOC_TYPE { get; set; }
        public string? DOC_NO { get; set; }
        public string? STAT_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public string? DEL_BY { get; set; }
        public DateTime? DEL_DATE { get; set; }
        public string? DEL_TYPE { get; set; }
    }
}
