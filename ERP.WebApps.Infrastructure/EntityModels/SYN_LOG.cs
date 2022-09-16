using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYN_LOG
    {
        public string SERVER { get; set; } = null!;
        public string TO_SERVER { get; set; } = null!;
        public string TRN_TYPE { get; set; } = null!;
        public string TRN_TABLE { get; set; } = null!;
        public string TRN_KEY { get; set; } = null!;
        public string TRN_CONDITION { get; set; } = null!;
        public string TRN_DATETIME { get; set; } = null!;
        public string? FINISH_DATETIME { get; set; }
        public long? RECORD_CRE { get; set; }
        public long? RECORD_UPD { get; set; }
        public long? RECORD_DEL { get; set; }
        public string? STAT_CODE { get; set; }
        public string? PGM_ID { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? REMARK { get; set; }
    }
}
