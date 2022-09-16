using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_SMPL_QLTY_TRN
    {
        public string COY_CODE { get; set; } = null!;
        public string FORM_NO { get; set; } = null!;
        public string SMPL_TYPE { get; set; } = null!;
        public decimal VALUE { get; set; }
    }
}
