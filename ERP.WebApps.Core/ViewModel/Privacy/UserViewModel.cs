using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.WebApps.Core.ViewModel.Privacy
{
    public class UserViewModel
    {
        public string USER_ID { get; set; }
        public string? USER_NAME { get; set; }
        public string? PWD { get; set; }
        public byte? PWDLENGTH { get; set; }
        public DateTime? EFF_DATE { get; set; }
        public DateTime? LAST_ACCESS { get; set; }
        public byte? BLOCK_CODE { get; set; }
        public byte? NEW_PASSWORD { get; set; }
        public string? LAST_UPD_PWD { get; set; }

    }
}
