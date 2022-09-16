using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_PROD_TYPE
    {
        public string COY_CODE { get; set; } = null!;
        public string PROD_TYPE { get; set; } = null!;
        public string? PROD_NAME { get; set; }
        public string? LONG_NAME { get; set; }
        public string? PROD_GROUP { get; set; }
        public bool? BLOCK_CODE { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
