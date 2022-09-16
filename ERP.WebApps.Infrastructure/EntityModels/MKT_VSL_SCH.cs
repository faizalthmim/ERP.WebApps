using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class MKT_VSL_SCH
    {
        public string COY_CODE { get; set; } = null!;
        public string VSL_CODE { get; set; } = null!;
        public string VOYG_NO { get; set; } = null!;
        public string MDO_NO { get; set; } = null!;
        public string SDO_NO { get; set; } = null!;
        public string? FROM_PORT_CODE { get; set; }
        public string? PORT_CODE { get; set; }
        public string? DELV_ADD1 { get; set; }
        public string? DELV_ADD2 { get; set; }
        public string? DELV_ADD3 { get; set; }
        public string? DELV_CTRY { get; set; }
        public string? EST_ARVL_DATE { get; set; }
        public string? ACT_ARVL_DATE { get; set; }
        public string? ACT_ARVL_HH { get; set; }
        public string? ACT_ARVL_MM { get; set; }
        public string? ARVL_CRE_BY { get; set; }
        public DateTime? ARVL_CRE_DATE { get; set; }
        public string? EST_BERT_DATE { get; set; }
        public string? ACT_BERT_DATE { get; set; }
        public string? ACT_BERT_HH { get; set; }
        public string? ACT_BERT_MM { get; set; }
        public string? LOAD_START_DATE { get; set; }
        public string? LOAD_START_HH { get; set; }
        public string? LOAD_START_MM { get; set; }
        public string? LOAD_FINISH_DATE { get; set; }
        public string? LOAD_FINISH_HH { get; set; }
        public string? LOAD_FINISH_MM { get; set; }
        public string? EST_DEPT_DATE { get; set; }
        public string? ACT_DEPT_DATE { get; set; }
        public string? ACT_DEPT_HH { get; set; }
        public string? ACT_DEPT_MM { get; set; }
        public string? DEPT_CRE_BY { get; set; }
        public DateTime? DEPT_CRE_DATE { get; set; }
        public string? QTY_UOM { get; set; }
        public decimal? EST_QTY { get; set; }
        public decimal? ACT_QTY { get; set; }
        public decimal? DIST_MILE { get; set; }
        public string? ACCPT_DATE { get; set; }
        public string? ACCPT_HH { get; set; }
        public string? ACCPT_MM { get; set; }
        public string? VOYG_NO_ACTL { get; set; }
        public string? REMARK { get; set; }
        public string? STAT_CODE { get; set; }
        public string? DPORT_DATE { get; set; }
        public string? DPORT_HH { get; set; }
        public string? DPORT_MM { get; set; }
        public string? DPORT_CRE_BY { get; set; }
        public DateTime? DPORT_CRE_DATE { get; set; }
        public string? BL_NO { get; set; }
        public string? COA_NO { get; set; }
        public string? COW_NO { get; set; }
        public decimal? COW_QTY { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
