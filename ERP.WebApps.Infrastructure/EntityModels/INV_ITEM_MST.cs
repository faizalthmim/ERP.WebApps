using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_ITEM_MST
    {
        public int ITEM_NO { get; set; }
        public string? PART_NO { get; set; }
        public string? CLEAN_PART_NO { get; set; }
        public string? BAR_CODE { get; set; }
        public string? ITEM_DESC { get; set; }
        public string? ITEM_GROUP { get; set; }
        public string? UOM { get; set; }
        public decimal? QTY { get; set; }
        public decimal? PRICE { get; set; }
        public decimal? CURR_PRICE { get; set; }
        public decimal? PRICE_HIST_1 { get; set; }
        public decimal? PRICE_HIST_2 { get; set; }
        public decimal? EFF_PRICE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
