using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class vw_approval_docs_all
    {
        public string COY_CODE { get; set; } = null!;
        public string DOC_TYPE { get; set; } = null!;
        public string DOC_NO { get; set; } = null!;
        public string? DOC_DATE { get; set; }
        public string? DOC_STATUS { get; set; }
        public string? APPRV_TYPE { get; set; }
        public string? CURR_APPRV { get; set; }
        public short? CURR_APPRV_LVL { get; set; }
        public short? CURR_APPRV_LVL_SEQ { get; set; }
        public string? CURR_APPRV_LVL_DESC { get; set; }
        public string? EDITABLE { get; set; }
        public string? LAST_APPRV_BY { get; set; }
        public string? LAST_APPRV_DATE { get; set; }
        public string? REMARK { get; set; }
        public string? CURR_USER_ID_ORI { get; set; }
        public string? CRE_BY { get; set; }
        public string? OWN_BY { get; set; }
        public string? CURR_USER_ID { get; set; }
    }
}
