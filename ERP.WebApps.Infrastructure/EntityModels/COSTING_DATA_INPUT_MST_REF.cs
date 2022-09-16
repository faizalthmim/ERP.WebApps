using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class COSTING_DATA_INPUT_MST_REF
    {
        public string COY_CODE { get; set; } = null!;
        public string DATA_TYPE { get; set; } = null!;
        public string DATA_TYPE_SEQ { get; set; } = null!;
        public string? DOC_TYPE { get; set; }
        public string? PGM_ID { get; set; }
        public string? PGM_TITLE { get; set; }
        public string? GRID_TITLE { get; set; }
        public string? DATA_COLUMN_HEADER { get; set; }
        public string? GROUP_COLUMN_1 { get; set; }
        public string? GROUP_COLUMN_2 { get; set; }
        public string? GROUP_COLUMN_3 { get; set; }
        public string? GROUP_COLUMN_4 { get; set; }
        public string? GROUP_COLUMN_5 { get; set; }
        public string? GROUP_COLUMN_6 { get; set; }
        public string? EDITABLE_FLAG_COLUMN_1 { get; set; }
        public string? EDITABLE_FLAG_COLUMN_2 { get; set; }
        public string? EDITABLE_FLAG_COLUMN_3 { get; set; }
        public string? EDITABLE_FLAG_COLUMN_4 { get; set; }
        public string? EDITABLE_FLAG_COLUMN_5 { get; set; }
        public string? EDITABLE_FLAG_COLUMN_6 { get; set; }
        public string? INPUT_COLUMN_1_HEADER { get; set; }
        public string? INPUT_COLUMN_2_HEADER { get; set; }
        public string? INPUT_COLUMN_3_HEADER { get; set; }
        public string? INPUT_COLUMN_4_HEADER { get; set; }
        public string? INPUT_COLUMN_5_HEADER { get; set; }
        public string? INPUT_COLUMN_6_HEADER { get; set; }
        public string? TOTAL_COLUMN_HEADER { get; set; }
        public string? TOTAL_IN_THE_END_OF_ROWS { get; set; }
    }
}
