using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class COSTING_DATA_INPUT
    {
        public string COY_CODE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public string DATA_TYPE { get; set; } = null!;
        public string DATA_TYPE_SEQ { get; set; } = null!;
        public string REC_CODE { get; set; } = null!;
        public string REC_KIND { get; set; } = null!;
        public string REC_TYPE { get; set; } = null!;
        public string WH_CODE { get; set; } = null!;
        public string CMT_TYPE { get; set; } = null!;
        public string BAG_TYPE { get; set; } = null!;
        public string INPUT_TYPE { get; set; } = null!;
        public string PROC_MONTH { get; set; } = null!;
        public decimal? DATA_INPUT { get; set; }
    }
}
