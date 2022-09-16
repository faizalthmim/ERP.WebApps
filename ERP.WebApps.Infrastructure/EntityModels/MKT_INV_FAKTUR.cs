using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_INV_FAKTUR
    {
        public string COY_CODE { get; set; } = null!;
        public string TRN_CODE { get; set; } = null!;
        public string STAT_CODE { get; set; } = null!;
        public string BRANCH_CODE { get; set; } = null!;
        public string INV_YEAR { get; set; } = null!;
        public int SEQ_NO { get; set; }
        public decimal START_IDX { get; set; }
        public decimal END_IDX { get; set; }
        public decimal LAST_IDX { get; set; }
        public string CRE_BY { get; set; } = null!;
        public DateTime? CRE_DATE { get; set; }
        public string UPD_BY { get; set; } = null!;
        public DateTime? UPD_DATE { get; set; }
        public string ACTIVE_CODE { get; set; } = null!;
    }
}
