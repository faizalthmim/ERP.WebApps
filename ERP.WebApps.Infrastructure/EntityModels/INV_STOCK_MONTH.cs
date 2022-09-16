using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class INV_STOCK_MONTH
    {
        public string COY_CODE { get; set; } = null!;
        public string ITEM_NO { get; set; } = null!;
        public string WH_CODE { get; set; } = null!;
        public string PROC_MONTH { get; set; } = null!;
        public decimal? BAL_QTY { get; set; }
        public decimal? BAL_AMT { get; set; }
        public decimal? MM_QTY_RCV { get; set; }
        public decimal? MM_AMT_RCV { get; set; }
        public decimal? MM_QTY_ISU { get; set; }
        public decimal? MM_AMT_ISU { get; set; }
        public decimal? MM_QTY_ADJ { get; set; }
        public decimal? MM_AMT_ADJ { get; set; }
        public decimal? YTD_QTY_RCV { get; set; }
        public decimal? YTD_AMT_RCV { get; set; }
        public decimal? YTD_QTY_ISU { get; set; }
        public decimal? YTD_AMT_ISU { get; set; }
        public decimal? YTD_QTY_ADJ { get; set; }
        public decimal? YTD_AMT_ADJ { get; set; }
        public string? RACK_LOCT { get; set; }
        public decimal? AVG_PRICE { get; set; }
    }
}
