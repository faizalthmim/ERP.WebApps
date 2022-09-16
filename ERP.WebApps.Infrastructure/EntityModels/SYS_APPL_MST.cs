using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_APPL_MST
    {
        public int ID { get; set; }
        public string? COY_CODE { get; set; }
        public string? PGM_ID { get; set; }
        /// <summary>
        /// Main Module e.g.: Finance, Sales etc
        /// </summary>
        public string? APP_SM_1 { get; set; }
        /// <summary>
        /// Sub Module e.g.: A/P, G/L etc
        /// </summary>
        public string? APP_SM_2 { get; set; }
        public string? PGM_DESC { get; set; }
        public byte? PGM_SEQ { get; set; }
        public byte? NEED_AUTH { get; set; }
        public string? PARAM { get; set; }
        public byte? BLOCK_CODE { get; set; }
    }
}
