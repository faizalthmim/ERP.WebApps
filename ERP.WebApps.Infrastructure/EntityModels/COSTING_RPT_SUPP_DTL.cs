using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class COSTING_RPT_SUPP_DTL
    {
        public string COY_CODE { get; set; } = null!;
        public string RPT_ID { get; set; } = null!;
        public string RPT_SEQ { get; set; } = null!;
        public string RPT_ITEM_NO { get; set; } = null!;
        public string? RPT_ITEM_DESC { get; set; }
        public string? QUERY_FOR_AMT { get; set; }
        public string? QUERY_FOR_AMT_YTD { get; set; }
    }
}
