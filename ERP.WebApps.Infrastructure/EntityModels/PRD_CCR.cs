using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_CCR
    {
        public string COY_CODE { get; set; } = null!;
        public string TRN_DATE { get; set; } = null!;
        public string? PROC_MONTH { get; set; }
        public decimal? CRH_KT { get; set; }
        public decimal? BL1_KT { get; set; }
        public decimal? BL2_KT { get; set; }
        public decimal? BL3_KT { get; set; }
        public decimal? BL4_KT { get; set; }
        public decimal? BL5_KT { get; set; }
        public decimal? BL6_KT { get; set; }
        public decimal? CONCENTRATE9A { get; set; }
        public decimal? FLOW9A { get; set; }
        public decimal? TAL_KT { get; set; }
        public decimal? BPP_KT { get; set; }
        public decimal? CONCENTRATETN { get; set; }
        public decimal? FLOWTN { get; set; }
        public decimal? CONCENTRATETN2 { get; set; }
        public decimal? FLOWTN2 { get; set; }
        public decimal? OTH_KT { get; set; }
        public decimal? G1_KWH { get; set; }
        public decimal? G2_KWH { get; set; }
        public decimal? G3_KWH { get; set; }
        public decimal? G4_KWH { get; set; }
        public decimal? POWER_CBT { get; set; }
        public decimal? POWER_T2 { get; set; }
        public decimal? POWER_T3 { get; set; }
        public decimal? POWER_PORT { get; set; }
        public decimal? POWER_PLANT_1 { get; set; }
        public decimal? POWER_PLANT_2 { get; set; }
        public string? FILE_NAME { get; set; }
        public string? REMARKS { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
        public decimal? G1_DIFF { get; set; }
        public decimal? G2_DIFF { get; set; }
        public decimal? G3_DIFF { get; set; }
        public decimal? G4_DIFF { get; set; }
        public decimal? CBT_DIFF { get; set; }
        public decimal? T2_DIFF { get; set; }
        public decimal? T3_DIFF { get; set; }
        public decimal? PORT_DIFF { get; set; }
        public decimal? PLANT1_DIFF { get; set; }
        public decimal? PLANT2_DIFF { get; set; }
        public string? PROC_DATE { get; set; }
    }
}
