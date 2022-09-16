using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class COSTING_DATA_INPUT_GROUP_REF
    {
        public string COY_CODE { get; set; } = null!;
        public string DATA_TYPE { get; set; } = null!;
        public string DATA_TYPE_SEQ { get; set; } = null!;
        public string GROUP_NAME { get; set; } = null!;
        public string? TOTAL_GROUP_HEADER { get; set; }
        public string? GROUP_COL_SEQ { get; set; }
    }
}
