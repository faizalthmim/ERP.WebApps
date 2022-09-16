using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class View_INV_STOCK
    {
        public string COY_CODE { get; set; } = null!;
        public string? ITEM_NO { get; set; }
        public string? wh_code { get; set; }
        public decimal? otw_qty { get; set; }
        public decimal? avail_qty { get; set; }
        public decimal? on_hand_qty { get; set; }
    }
}
