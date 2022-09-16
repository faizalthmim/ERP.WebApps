using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_SMPL_REF
    {
        public string COY_CODE { get; set; } = null!;
        public string UNTT { get; set; } = null!;
        public string PLAN_CODE { get; set; } = null!;
        public string SMPL_TYPE { get; set; } = null!;
        public string? SMPL_DESC { get; set; }
        public int? SEQ { get; set; }
    }
}
