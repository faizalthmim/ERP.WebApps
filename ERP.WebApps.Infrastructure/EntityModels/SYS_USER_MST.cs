using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class SYS_USER_MST
    {
        public string USER_ID { get; set; }
        public string? USER_NAME { get; set; }
        public byte? USER_TYPE { get; set; }
        public string? PWD { get; set; }
        public byte? PWDLENGTH { get; set; }
        public DateTime? EFF_DATE { get; set; }
        public DateTime? LAST_ACCESS { get; set; }
        public byte? BLOCK_CODE { get; set; }
        public byte? NEW_PASSWORD { get; set; }
        public string? LAST_UPD_PWD { get; set; }
    }
}
