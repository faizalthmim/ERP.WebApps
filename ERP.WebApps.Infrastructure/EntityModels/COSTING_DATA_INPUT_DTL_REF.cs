using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class COSTING_DATA_INPUT_DTL_REF
    {
        public string COY_CODE { get; set; } = null!;
        public string DATA_TYPE { get; set; } = null!;
        public string DATA_TYPE_SEQ { get; set; } = null!;
        public string REC_CODE { get; set; } = null!;
        public string REC_KIND { get; set; } = null!;
        public string REC_TYPE { get; set; } = null!;
        public string WH_CODE { get; set; } = null!;
        public string? DATA_COLUMN_DETAIL { get; set; }
        public string? INPUT_COLUMN_1_QUERY { get; set; }
        public string? INPUT_COLUMN_2_QUERY { get; set; }
        public string? INPUT_COLUMN_3_QUERY { get; set; }
        public string? INPUT_COLUMN_4_QUERY { get; set; }
        public string? INPUT_COLUMN_5_QUERY { get; set; }
        public string? INPUT_COLUMN_6_QUERY { get; set; }
        public string? INPUT_COLUMN_1_DEFAULT_VAL_QUERY { get; set; }
        public string? INPUT_COLUMN_2_DEFAULT_VAL_QUERY { get; set; }
        public string? INPUT_COLUMN_3_DEFAULT_VAL_QUERY { get; set; }
        public string? INPUT_COLUMN_4_DEFAULT_VAL_QUERY { get; set; }
        public string? INPUT_COLUMN_5_DEFAULT_VAL_QUERY { get; set; }
        public string? INPUT_COLUMN_6_DEFAULT_VAL_QUERY { get; set; }
        public string? EDITABLE_FLAG_COLUMN_1 { get; set; }
        public string? EDITABLE_FLAG_COLUMN_2 { get; set; }
        public string? EDITABLE_FLAG_COLUMN_3 { get; set; }
        public string? EDITABLE_FLAG_COLUMN_4 { get; set; }
        public string? EDITABLE_FLAG_COLUMN_5 { get; set; }
        public string? EDITABLE_FLAG_COLUMN_6 { get; set; }
        public string? ORDER_SEQ { get; set; }
        public string? COST_CTGR { get; set; }
    }
}
