using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_COY_MST
    {
        public string COY_CODE { get; set; } = null!;
        public string? COY_NAME { get; set; }
        public string? COY_WEBSITE { get; set; }
        public string? ADDR_1 { get; set; }
        public string? ADDR_2 { get; set; }
        public string? ADDR_3 { get; set; }
        public string? CITY { get; set; }
        public string? NPWP { get; set; }
        public string? NPWP_ADDR { get; set; }
        public string? PKP_NO { get; set; }
        public string? PKP_DATE { get; set; }
        public string? PHONE { get; set; }
        public string? FAX { get; set; }
        /// <summary>
        /// flag to indicate whether this particular company needs to have &quot;voucher verification&quot; feature in finance accounting module or not (0 means no need, 1 means need)
        /// </summary>
        public string? FIN_VCH_VERIFY { get; set; }
        public string? FIN_COST_CTR_IN_CIP { get; set; }
        public string? FXA_CIP_PREOPS { get; set; }
        public string? FIN_PL_START_ACCT { get; set; }
        public string? PR_ISO_NO { get; set; }
        public string? PO_ISO_NO { get; set; }
        public string? GAR_ISO_NO { get; set; }
        public string? GRR_ISO_NO { get; set; }
        public string? SEND_EMAIL_FOR_WF_DOC_TO_APPROVER { get; set; }
        public string? SEND_EMAIL_FOR_WF_DOC_TO_CREATOR { get; set; }
        public string? SHOW_LINK_PRINT_PO_FOR_INTERNAL { get; set; }
        public string? SEND_EMAIL_FOR_PO_TO_SUPPLIER { get; set; }
        public string? COY_GROUP { get; set; }
        public string? ALLOW_MULTIPLE_EMP_ADV_FOR_ONE_EMP { get; set; }
        public string? PURCHASING_MANAGER_ID { get; set; }
        public string? ACCOUNTING_START_MONTH { get; set; }
        public string? SHOW_PPN_IN_PO_SUPPLIER { get; set; }
        public string? SEND_EMAIL_FOR_GAR_TO_PURCHASER { get; set; }
        public string? SHOW_SHIP_COST_ADV_PRF { get; set; }
    }
}
