using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class ERP_PROD_JSContext : DbContext
    {
        public ERP_PROD_JSContext()
        {
        }

        public ERP_PROD_JSContext(DbContextOptions<ERP_PROD_JSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ADV_MST> ADV_MSTs { get; set; } = null!;
        public virtual DbSet<ADV_TRN> ADV_TRNs { get; set; } = null!;
        public virtual DbSet<AP_MST> AP_MSTs { get; set; } = null!;
        public virtual DbSet<AP_MST_DEL> AP_MST_DELs { get; set; } = null!;
        public virtual DbSet<AP_MST_FC> AP_MST_FCs { get; set; } = null!;
        public virtual DbSet<AP_MST_FC_DEL> AP_MST_FC_DELs { get; set; } = null!;
        public virtual DbSet<AP_TRN> AP_TRNs { get; set; } = null!;
        public virtual DbSet<AP_TRN_DEL> AP_TRN_DELs { get; set; } = null!;
        public virtual DbSet<AR_MST> AR_MSTs { get; set; } = null!;
        public virtual DbSet<AR_MST_DEL> AR_MST_DELs { get; set; } = null!;
        public virtual DbSet<AR_MST_FC> AR_MST_FCs { get; set; } = null!;
        public virtual DbSet<AR_MST_FC_DEL> AR_MST_FC_DELs { get; set; } = null!;
        public virtual DbSet<AR_RECEIPT_MST> AR_RECEIPT_MSTs { get; set; } = null!;
        public virtual DbSet<AR_RECEIPT_MST_DEL> AR_RECEIPT_MST_DELs { get; set; } = null!;
        public virtual DbSet<AR_RECEIPT_TRN> AR_RECEIPT_TRNs { get; set; } = null!;
        public virtual DbSet<AR_RECEIPT_TRN_DEL> AR_RECEIPT_TRN_DELs { get; set; } = null!;
        public virtual DbSet<AR_TRN> AR_TRNs { get; set; } = null!;
        public virtual DbSet<AR_TRN_DEL> AR_TRN_DELs { get; set; } = null!;
        public virtual DbSet<CIP_PROJ_MST> CIP_PROJ_MSTs { get; set; } = null!;
        public virtual DbSet<CIP_PROJ_MST_DEL> CIP_PROJ_MST_DELs { get; set; } = null!;
        public virtual DbSet<CIP_PROJ_TRN> CIP_PROJ_TRNs { get; set; } = null!;
        public virtual DbSet<CIP_PROJ_TRN_DEL> CIP_PROJ_TRN_DELs { get; set; } = null!;
        public virtual DbSet<COSTING_ACCT_REF> COSTING_ACCT_REFs { get; set; } = null!;
        public virtual DbSet<COSTING_DATA_INPUT> COSTING_DATA_INPUTs { get; set; } = null!;
        public virtual DbSet<COSTING_DATA_INPUT_DTL_REF> COSTING_DATA_INPUT_DTL_REFs { get; set; } = null!;
        public virtual DbSet<COSTING_DATA_INPUT_GROUP_REF> COSTING_DATA_INPUT_GROUP_REFs { get; set; } = null!;
        public virtual DbSet<COSTING_DATA_INPUT_MST_REF> COSTING_DATA_INPUT_MST_REFs { get; set; } = null!;
        public virtual DbSet<COSTING_DOC_MST> COSTING_DOC_MSTs { get; set; } = null!;
        public virtual DbSet<COSTING_ELM_TRN> COSTING_ELM_TRNs { get; set; } = null!;
        public virtual DbSet<COSTING_RPT_DTL> COSTING_RPT_DTLs { get; set; } = null!;
        public virtual DbSet<COSTING_RPT_MST> COSTING_RPT_MSTs { get; set; } = null!;
        public virtual DbSet<COSTING_RPT_SUPP_DTL> COSTING_RPT_SUPP_DTLs { get; set; } = null!;
        public virtual DbSet<FIN_ACCT_COA> FIN_ACCT_COAs { get; set; } = null!;
        public virtual DbSet<FIN_ACCT_EXP> FIN_ACCT_EXPs { get; set; } = null!;
        public virtual DbSet<FIN_ACCT_REF> FIN_ACCT_REFs { get; set; } = null!;
        public virtual DbSet<FIN_COST_BUDGET> FIN_COST_BUDGETs { get; set; } = null!;
        public virtual DbSet<FIN_COST_BUDGET_DEL> FIN_COST_BUDGET_DELs { get; set; } = null!;
        public virtual DbSet<FIN_COST_BUDGET_REV> FIN_COST_BUDGET_REVs { get; set; } = null!;
        public virtual DbSet<FIN_COST_BUDGET_REV_DEL> FIN_COST_BUDGET_REV_DELs { get; set; } = null!;
        public virtual DbSet<FIN_COST_BUDGET_SUPP> FIN_COST_BUDGET_SUPPs { get; set; } = null!;
        public virtual DbSet<FIN_COST_BUDGET_SUPP_DEL> FIN_COST_BUDGET_SUPP_DELs { get; set; } = null!;
        public virtual DbSet<FIN_COST_BUDGET_SUPP_TTV> FIN_COST_BUDGET_SUPP_TTVs { get; set; } = null!;
        public virtual DbSet<FIN_COST_BUDGET_SUPP_TTV_DEL> FIN_COST_BUDGET_SUPP_TTV_DELs { get; set; } = null!;
        public virtual DbSet<FIN_COST_BUDGET_TTV> FIN_COST_BUDGET_TTVs { get; set; } = null!;
        public virtual DbSet<FIN_COST_BUDGET_TTV_DEL> FIN_COST_BUDGET_TTV_DELs { get; set; } = null!;
        public virtual DbSet<FIN_COST_CTR> FIN_COST_CTRs { get; set; } = null!;
        public virtual DbSet<FIN_COST_ELM_LEDG> FIN_COST_ELM_LEDGs { get; set; } = null!;
        public virtual DbSet<FIN_COST_ELM_TRN> FIN_COST_ELM_TRNs { get; set; } = null!;
        public virtual DbSet<FIN_EXP_LEDG> FIN_EXP_LEDGs { get; set; } = null!;
        public virtual DbSet<FIN_GEN_LEDG> FIN_GEN_LEDGs { get; set; } = null!;
        public virtual DbSet<FIN_GRP_COA> FIN_GRP_COAs { get; set; } = null!;
        public virtual DbSet<FIN_GRP_CODE> FIN_GRP_CODEs { get; set; } = null!;
        public virtual DbSet<FIN_ILT_REF> FIN_ILT_REFs { get; set; } = null!;
        public virtual DbSet<FIN_QUERY> FIN_QUERies { get; set; } = null!;
        public virtual DbSet<FIN_TRN_CODE> FIN_TRN_CODEs { get; set; } = null!;
        public virtual DbSet<FIN_VCH_ILT> FIN_VCH_ILTs { get; set; } = null!;
        public virtual DbSet<FIN_VCH_ITM> FIN_VCH_ITMs { get; set; } = null!;
        public virtual DbSet<FIN_VCH_ITM_DEL> FIN_VCH_ITM_DELs { get; set; } = null!;
        public virtual DbSet<FIN_VCH_RMK> FIN_VCH_RMKs { get; set; } = null!;
        public virtual DbSet<FIN_VCH_RMK_DEL> FIN_VCH_RMK_DELs { get; set; } = null!;
        public virtual DbSet<FIN_VCH_TAKE> FIN_VCH_TAKEs { get; set; } = null!;
        public virtual DbSet<FRS_RPT_LINE> FRS_RPT_LINEs { get; set; } = null!;
        public virtual DbSet<FRS_RPT_LINE_CALC> FRS_RPT_LINE_CALCs { get; set; } = null!;
        public virtual DbSet<FRS_RPT_LINE_DTL> FRS_RPT_LINE_DTLs { get; set; } = null!;
        public virtual DbSet<FRS_RPT_MST> FRS_RPT_MSTs { get; set; } = null!;
        public virtual DbSet<FXA_ACCT_REF> FXA_ACCT_REFs { get; set; } = null!;
        public virtual DbSet<FXA_ASST_DEF> FXA_ASST_DEFs { get; set; } = null!;
        public virtual DbSet<FXA_ASST_MST> FXA_ASST_MSTs { get; set; } = null!;
        public virtual DbSet<FXA_ASST_MST_DEL> FXA_ASST_MST_DELs { get; set; } = null!;
        public virtual DbSet<FXA_ASST_TRN> FXA_ASST_TRNs { get; set; } = null!;
        public virtual DbSet<FXA_ASST_TRN_DEL> FXA_ASST_TRN_DELs { get; set; } = null!;
        public virtual DbSet<FXA_FA_CTGR> FXA_FA_CTGRs { get; set; } = null!;
        public virtual DbSet<FXA_FA_GRP> FXA_FA_GRPs { get; set; } = null!;
        public virtual DbSet<FXA_TRN_CODE> FXA_TRN_CODEs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_ADDR> HRS_EMP_ADDRs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_ADDR_DEL> HRS_EMP_ADDR_DELs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_CERTIFICATE> HRS_EMP_CERTIFICATEs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_CERTIFICATE_DEL> HRS_EMP_CERTIFICATE_DELs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_EDUCATION> HRS_EMP_EDUCATIONs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_EDUCATION_DEL> HRS_EMP_EDUCATION_DELs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_FAMILY> HRS_EMP_FAMILies { get; set; } = null!;
        public virtual DbSet<HRS_EMP_FAMILY_DEL> HRS_EMP_FAMILY_DELs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_PERSONAL_INFO> HRS_EMP_PERSONAL_INFOs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_PERSONAL_INFO_DEL> HRS_EMP_PERSONAL_INFO_DELs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_PREV_EMPLOYMENT> HRS_EMP_PREV_EMPLOYMENTs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_PREV_EMPLOYMENT_DEL> HRS_EMP_PREV_EMPLOYMENT_DELs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_RELATION> HRS_EMP_RELATIONs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_RELATION_DEL> HRS_EMP_RELATION_DELs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_SKILL> HRS_EMP_SKILLs { get; set; } = null!;
        public virtual DbSet<HRS_EMP_SKILL_DEL> HRS_EMP_SKILL_DELs { get; set; } = null!;
        public virtual DbSet<INV_ACCT_REF> INV_ACCT_REFs { get; set; } = null!;
        public virtual DbSet<INV_ADJ_DTL> INV_ADJ_DTLs { get; set; } = null!;
        public virtual DbSet<INV_ADJ_MST> INV_ADJ_MSTs { get; set; } = null!;
        public virtual DbSet<INV_GAR_DTL> INV_GAR_DTLs { get; set; } = null!;
        public virtual DbSet<INV_GAR_MST> INV_GAR_MSTs { get; set; } = null!;
        public virtual DbSet<INV_GRR_DTL> INV_GRR_DTLs { get; set; } = null!;
        public virtual DbSet<INV_GRR_MST> INV_GRR_MSTs { get; set; } = null!;
        public virtual DbSet<INV_GTR_DTL> INV_GTR_DTLs { get; set; } = null!;
        public virtual DbSet<INV_GTR_MST> INV_GTR_MSTs { get; set; } = null!;
        public virtual DbSet<INV_ITEM_MST> INV_ITEM_MSTs { get; set; } = null!;
        public virtual DbSet<INV_ITEM_PURCHASER_RELATED_MST> INV_ITEM_PURCHASER_RELATED_MSTs { get; set; } = null!;
        public virtual DbSet<INV_KIND_REF> INV_KIND_REFs { get; set; } = null!;
        public virtual DbSet<INV_MIR_DTL> INV_MIR_DTLs { get; set; } = null!;
        public virtual DbSet<INV_MIR_MST> INV_MIR_MSTs { get; set; } = null!;
        public virtual DbSet<INV_MIS_DTL> INV_MIS_DTLs { get; set; } = null!;
        public virtual DbSet<INV_MIS_MST> INV_MIS_MSTs { get; set; } = null!;
        public virtual DbSet<INV_MST> INV_MSTs { get; set; } = null!;
        public virtual DbSet<INV_MST_HIST> INV_MST_HISTs { get; set; } = null!;
        public virtual DbSet<INV_RAW_MAT_DPCH_ST> INV_RAW_MAT_DPCH_STs { get; set; } = null!;
        public virtual DbSet<INV_STOCK> INV_STOCKs { get; set; } = null!;
        public virtual DbSet<INV_STOCK_MONTH> INV_STOCK_MONTHs { get; set; } = null!;
        public virtual DbSet<INV_UOM> INV_UOMs { get; set; } = null!;
        public virtual DbSet<INV_VMR_DTL> INV_VMR_DTLs { get; set; } = null!;
        public virtual DbSet<INV_VMR_MST> INV_VMR_MSTs { get; set; } = null!;
        public virtual DbSet<INV_WAREHOUSE> INV_WAREHOUSEs { get; set; } = null!;
        public virtual DbSet<MKT_DEST_REF> MKT_DEST_REFs { get; set; } = null!;
        public virtual DbSet<MKT_DPCH_LOCT> MKT_DPCH_LOCTs { get; set; } = null!;
        public virtual DbSet<MKT_DPCH_REF> MKT_DPCH_REFs { get; set; } = null!;
        public virtual DbSet<MKT_DPCH_STG> MKT_DPCH_STGs { get; set; } = null!;
        public virtual DbSet<MKT_DPCH_STG_DEL> MKT_DPCH_STG_DELs { get; set; } = null!;
        public virtual DbSet<MKT_INV_FAKTUR> MKT_INV_FAKTURs { get; set; } = null!;
        public virtual DbSet<MKT_INV_MST> MKT_INV_MSTs { get; set; } = null!;
        public virtual DbSet<MKT_INV_MST_DEL> MKT_INV_MST_DELs { get; set; } = null!;
        public virtual DbSet<MKT_INV_SPEC> MKT_INV_SPECs { get; set; } = null!;
        public virtual DbSet<MKT_INV_SPEC_DEL> MKT_INV_SPEC_DELs { get; set; } = null!;
        public virtual DbSet<MKT_MDO> MKT_MDOs { get; set; } = null!;
        public virtual DbSet<MKT_MDO_DEL> MKT_MDO_DELs { get; set; } = null!;
        public virtual DbSet<MKT_MDO_SPEC> MKT_MDO_SPECs { get; set; } = null!;
        public virtual DbSet<MKT_MDO_SPEC_DEL> MKT_MDO_SPEC_DELs { get; set; } = null!;
        public virtual DbSet<MKT_PACKING> MKT_PACKINGs { get; set; } = null!;
        public virtual DbSet<MKT_PORT_MST> MKT_PORT_MSTs { get; set; } = null!;
        public virtual DbSet<MKT_PROD_TYPE> MKT_PROD_TYPEs { get; set; } = null!;
        public virtual DbSet<MKT_SDO> MKT_SDOs { get; set; } = null!;
        public virtual DbSet<MKT_SDO_ASGN> MKT_SDO_ASGNs { get; set; } = null!;
        public virtual DbSet<MKT_SDO_ASGN_DEL> MKT_SDO_ASGN_DELs { get; set; } = null!;
        public virtual DbSet<MKT_SDO_DEL> MKT_SDO_DELs { get; set; } = null!;
        public virtual DbSet<MKT_VSL_EXP> MKT_VSL_EXPs { get; set; } = null!;
        public virtual DbSet<MKT_VSL_EXP_DEL> MKT_VSL_EXP_DELs { get; set; } = null!;
        public virtual DbSet<MKT_VSL_MST> MKT_VSL_MSTs { get; set; } = null!;
        public virtual DbSet<MKT_VSL_MST_DEL> MKT_VSL_MST_DELs { get; set; } = null!;
        public virtual DbSet<MKT_VSL_SCH> MKT_VSL_SCHes { get; set; } = null!;
        public virtual DbSet<MKT_VSL_SCH_DEL> MKT_VSL_SCH_DELs { get; set; } = null!;
        public virtual DbSet<OP_BALANCE> OP_BALANCEs { get; set; } = null!;
        public virtual DbSet<OTH_DOC> OTH_DOCs { get; set; } = null!;
        public virtual DbSet<OTH_DOC_DEL> OTH_DOC_DELs { get; set; } = null!;
        public virtual DbSet<PRD_BDGT_RVSD_MST> PRD_BDGT_RVSD_MSTs { get; set; } = null!;
        public virtual DbSet<PRD_BDGT_RVSD_TRN> PRD_BDGT_RVSD_TRNs { get; set; } = null!;
        public virtual DbSet<PRD_BDGT_RVSD_TRN_DEL> PRD_BDGT_RVSD_TRN_DELs { get; set; } = null!;
        public virtual DbSet<PRD_BDGT_TYPE_MST> PRD_BDGT_TYPE_MSTs { get; set; } = null!;
        public virtual DbSet<PRD_BDGT_TYPE_REF> PRD_BDGT_TYPE_REFs { get; set; } = null!;
        public virtual DbSet<PRD_BDGT_YRLY_MST> PRD_BDGT_YRLY_MSTs { get; set; } = null!;
        public virtual DbSet<PRD_BDGT_YRLY_TRN> PRD_BDGT_YRLY_TRNs { get; set; } = null!;
        public virtual DbSet<PRD_BDGT_YRLY_TRN_DEL> PRD_BDGT_YRLY_TRN_DELs { get; set; } = null!;
        public virtual DbSet<PRD_CCR> PRD_CCRs { get; set; } = null!;
        public virtual DbSet<PRD_CCR_TMP> PRD_CCR_TMPs { get; set; } = null!;
        public virtual DbSet<PRD_CRTFY_MST> PRD_CRTFY_MSTs { get; set; } = null!;
        public virtual DbSet<PRD_CRTFY_TRN> PRD_CRTFY_TRNs { get; set; } = null!;
        public virtual DbSet<PRD_MCHN_DATum> PRD_MCHN_DATAs { get; set; } = null!;
        public virtual DbSet<PRD_MCHN_MST> PRD_MCHN_MSTs { get; set; } = null!;
        public virtual DbSet<PRD_MINING_SITE> PRD_MINING_SITEs { get; set; } = null!;
        public virtual DbSet<PRD_PRDCT_MST> PRD_PRDCT_MSTs { get; set; } = null!;
        public virtual DbSet<PRD_PRDCT_STG_REF> PRD_PRDCT_STG_REFs { get; set; } = null!;
        public virtual DbSet<PRD_PROC_STG_MST> PRD_PROC_STG_MSTs { get; set; } = null!;
        public virtual DbSet<PRD_PROD_TRN> PRD_PROD_TRNs { get; set; } = null!;
        public virtual DbSet<PRD_PROD_TRN_ACTUAL> PRD_PROD_TRN_ACTUALs { get; set; } = null!;
        public virtual DbSet<PRD_PROD_TRN_ACTUAL_DEL> PRD_PROD_TRN_ACTUAL_DELs { get; set; } = null!;
        public virtual DbSet<PRD_PWR_TRN> PRD_PWR_TRNs { get; set; } = null!;
        public virtual DbSet<PRD_SMPL_QLTY_MST> PRD_SMPL_QLTY_MSTs { get; set; } = null!;
        public virtual DbSet<PRD_SMPL_QLTY_TRN> PRD_SMPL_QLTY_TRNs { get; set; } = null!;
        public virtual DbSet<PRD_SMPL_REF> PRD_SMPL_REFs { get; set; } = null!;
        public virtual DbSet<PRD_SMPL_SPEC> PRD_SMPL_SPECs { get; set; } = null!;
        public virtual DbSet<PRD_STOCK_MST> PRD_STOCK_MSTs { get; set; } = null!;
        public virtual DbSet<PRD_STOCK_TRN> PRD_STOCK_TRNs { get; set; } = null!;
        public virtual DbSet<PRD_STOCK_YARD> PRD_STOCK_YARDs { get; set; } = null!;
        public virtual DbSet<PRD_STOCK_YARD_DEL> PRD_STOCK_YARD_DELs { get; set; } = null!;
        public virtual DbSet<PRD_VHC_MST> PRD_VHC_MSTs { get; set; } = null!;
        public virtual DbSet<PRD_WEIGHBRIDGE> PRD_WEIGHBRIDGEs { get; set; } = null!;
        public virtual DbSet<PRD_WGHNG_TRN> PRD_WGHNG_TRNs { get; set; } = null!;
        public virtual DbSet<PRE_PROJ_MST> PRE_PROJ_MSTs { get; set; } = null!;
        public virtual DbSet<PRE_PROJ_MST_DEL> PRE_PROJ_MST_DELs { get; set; } = null!;
        public virtual DbSet<PRE_PROJ_TRN> PRE_PROJ_TRNs { get; set; } = null!;
        public virtual DbSet<PRE_PROJ_TRN_DEL> PRE_PROJ_TRN_DELs { get; set; } = null!;
        public virtual DbSet<PRF_ATT_DET> PRF_ATT_DETs { get; set; } = null!;
        public virtual DbSet<PRF_MST_INFO> PRF_MST_INFOs { get; set; } = null!;
        public virtual DbSet<PRF_PAY_ADJ_TRN> PRF_PAY_ADJ_TRNs { get; set; } = null!;
        public virtual DbSet<PRF_PAY_ADJ_TRN_DEL> PRF_PAY_ADJ_TRN_DELs { get; set; } = null!;
        public virtual DbSet<PRF_TRN_DET> PRF_TRN_DETs { get; set; } = null!;
        public virtual DbSet<PUR_PO_DTL> PUR_PO_DTLs { get; set; } = null!;
        public virtual DbSet<PUR_PO_HIST> PUR_PO_HISTs { get; set; } = null!;
        public virtual DbSet<PUR_PO_MST> PUR_PO_MSTs { get; set; } = null!;
        public virtual DbSet<PUR_PR> PUR_PRs { get; set; } = null!;
        public virtual DbSet<PUR_PR_DTL> PUR_PR_DTLs { get; set; } = null!;
        public virtual DbSet<PUR_PR_HIST> PUR_PR_HISTs { get; set; } = null!;
        public virtual DbSet<PUR_PR_MST> PUR_PR_MSTs { get; set; } = null!;
        public virtual DbSet<SYN_LOG> SYN_LOGs { get; set; } = null!;
        public virtual DbSet<SYN_LOG_DEL> SYN_LOG_DELs { get; set; } = null!;
        public virtual DbSet<SYN_LOG_RECV> SYN_LOG_RECVs { get; set; } = null!;
        public virtual DbSet<SYN_RECV> SYN_RECVs { get; set; } = null!;
        public virtual DbSet<SYN_RECV_DEL> SYN_RECV_DELs { get; set; } = null!;
        public virtual DbSet<SYN_SEND> SYN_SENDs { get; set; } = null!;
        public virtual DbSet<SYN_SEND_DEL> SYN_SEND_DELs { get; set; } = null!;
        public virtual DbSet<SYN_USER> SYN_USERs { get; set; } = null!;
        public virtual DbSet<SYN_USER_DEL> SYN_USER_DELs { get; set; } = null!;
        public virtual DbSet<SYS_APPL_AUTH_TRN> SYS_APPL_AUTH_TRNs { get; set; } = null!;
        public virtual DbSet<SYS_APPL_DISP_SEQ> SYS_APPL_DISP_SEQs { get; set; } = null!;
        public virtual DbSet<SYS_APPL_FAV> SYS_APPL_FAVs { get; set; } = null!;
        public virtual DbSet<SYS_APPL_MST> SYS_APPL_MSTs { get; set; } = null!;
        public virtual DbSet<SYS_APPL_START> SYS_APPL_STARTs { get; set; } = null!;
        public virtual DbSet<SYS_APPRV_MST> SYS_APPRV_MSTs { get; set; } = null!;
        public virtual DbSet<SYS_APPRV_MST_REF> SYS_APPRV_MST_REFs { get; set; } = null!;
        public virtual DbSet<SYS_CAL_MST> SYS_CAL_MSTs { get; set; } = null!;
        public virtual DbSet<SYS_CLOSING_ADM> SYS_CLOSING_ADMs { get; set; } = null!;
        public virtual DbSet<SYS_COY_AUTH_TRN> SYS_COY_AUTH_TRNs { get; set; } = null!;
        public virtual DbSet<SYS_COY_MST> SYS_COY_MSTs { get; set; } = null!;
        public virtual DbSet<SYS_CTRY_MST> SYS_CTRY_MSTs { get; set; } = null!;
        public virtual DbSet<SYS_CURR_MST> SYS_CURR_MSTs { get; set; } = null!;
        public virtual DbSet<SYS_CURR_RATE> SYS_CURR_RATEs { get; set; } = null!;
        public virtual DbSet<SYS_DISCUSS> SYS_DISCUSSes { get; set; } = null!;
        public virtual DbSet<SYS_DISCUSS_MSG> SYS_DISCUSS_MSGs { get; set; } = null!;
        public virtual DbSet<SYS_DISCUSS_READ> SYS_DISCUSS_READs { get; set; } = null!;
        public virtual DbSet<SYS_DOC_APPRV> SYS_DOC_APPRVs { get; set; } = null!;
        public virtual DbSet<SYS_DOC_APPRV_DET> SYS_DOC_APPRV_DETs { get; set; } = null!;
        public virtual DbSet<SYS_DOC_ATTCH> SYS_DOC_ATTCHes { get; set; } = null!;
        public virtual DbSet<SYS_DOC_ATTCH_DEL> SYS_DOC_ATTCH_DELs { get; set; } = null!;
        public virtual DbSet<SYS_DOC_PRINT> SYS_DOC_PRINTs { get; set; } = null!;
        public virtual DbSet<SYS_EMP_MST> SYS_EMP_MSTs { get; set; } = null!;
        public virtual DbSet<SYS_ERP_MSG> SYS_ERP_MSGs { get; set; } = null!;
        public virtual DbSet<SYS_ERP_REF> SYS_ERP_REFs { get; set; } = null!;
        public virtual DbSet<SYS_NUMBERING> SYS_NUMBERINGs { get; set; } = null!;
        public virtual DbSet<SYS_ORG_STR> SYS_ORG_STRs { get; set; } = null!;
        public virtual DbSet<SYS_OTHER_REF> SYS_OTHER_REFs { get; set; } = null!;
        public virtual DbSet<SYS_PAYEE_MST> SYS_PAYEE_MSTs { get; set; } = null!;
        public virtual DbSet<SYS_PAYEE_MST_DEL> SYS_PAYEE_MST_DELs { get; set; } = null!;
        public virtual DbSet<SYS_ROLE_MST> SYS_ROLE_MSTs { get; set; } = null!;
        public virtual DbSet<SYS_ROLE_SETUP> SYS_ROLE_SETUPs { get; set; } = null!;
        public virtual DbSet<SYS_USER_MST> SYS_USER_MSTs { get; set; } = null!;
        public virtual DbSet<SYS_USER_SURR> SYS_USER_SURRs { get; set; } = null!;
        public virtual DbSet<SYS_USER_SURR_DEL> SYS_USER_SURR_DELs { get; set; } = null!;
        public virtual DbSet<TEMP_POWER> TEMP_POWERs { get; set; } = null!;
        public virtual DbSet<TEMP_PRD_CCR> TEMP_PRD_CCRs { get; set; } = null!;
        public virtual DbSet<TEMP_SHIPMENT> TEMP_SHIPMENTs { get; set; } = null!;
        public virtual DbSet<TEMP_SHIPMENT_NEW> TEMP_SHIPMENT_NEWs { get; set; } = null!;
        public virtual DbSet<TEMP_STOCK> TEMP_STOCKs { get; set; } = null!;
        public virtual DbSet<UploadCOA> UploadCOAs { get; set; } = null!;
        public virtual DbSet<UploadCOA2> UploadCOA2s { get; set; } = null!;
        public virtual DbSet<View_EXP_GEN_LEDG> View_EXP_GEN_LEDGs { get; set; } = null!;
        public virtual DbSet<View_FIN_COST_ELM_LEDG> View_FIN_COST_ELM_LEDGs { get; set; } = null!;
        public virtual DbSet<View_FIN_EXP_LEDG> View_FIN_EXP_LEDGs { get; set; } = null!;
        public virtual DbSet<View_FIN_EXP_LEDG_PLUS_VOUCHER_UNAPPROVED> View_FIN_EXP_LEDG_PLUS_VOUCHER_UNAPPROVEDs { get; set; } = null!;
        public virtual DbSet<View_FIN_GEN_LEDG> View_FIN_GEN_LEDGs { get; set; } = null!;
        public virtual DbSet<View_INV_STOCK> View_INV_STOCKs { get; set; } = null!;
        public virtual DbSet<View_Outstanding_PR> View_Outstanding_PRs { get; set; } = null!;
        public virtual DbSet<View_PRF_ADV_Voucher> View_PRF_ADV_Vouchers { get; set; } = null!;
        public virtual DbSet<Z_CAD_ADV_DTL> Z_CAD_ADV_DTLs { get; set; } = null!;
        public virtual DbSet<Z_CAD_ADV_EXP> Z_CAD_ADV_EXPs { get; set; } = null!;
        public virtual DbSet<Z_CAD_ADV_MST> Z_CAD_ADV_MSTs { get; set; } = null!;
        public virtual DbSet<Z_CONV_COST> Z_CONV_COSTs { get; set; } = null!;
        public virtual DbSet<Z_JS_ACCT> Z_JS_ACCTs { get; set; } = null!;
        public virtual DbSet<Z_MAP_SJU> Z_MAP_SJUs { get; set; } = null!;
        public virtual DbSet<Z_Supplier> Z_Suppliers { get; set; } = null!;
        public virtual DbSet<Z_VOUCHER_ENTRY> Z_VOUCHER_ENTRies { get; set; } = null!;
        public virtual DbSet<vw_approval_doc> vw_approval_docs { get; set; } = null!;
        public virtual DbSet<vw_approval_docs_all> vw_approval_docs_alls { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=app-dev;Database=ERP_PROD_JS;Persist Security Info=False;User ID=sa;Password=sapasswd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADV_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO })
                    .HasName("PK_ADV_MST_1");

                entity.ToTable("ADV_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADV_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.ADV_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ADV_BANK_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADV_BANK_TRN_CLS)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADV_OTHER_BANK_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ADV_OTHER_BANK_TRN_CLS)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ADV_PAY_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ADV_VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ADV_VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AP_AMT)
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AP_AMT_FOREIGN)
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AUTO_VCH)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AUTO_VCH_CLR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BANK_ACCT_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_ACCT_NO)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CLR_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CLR_REMARK)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.CLR_VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CONTACT_PERSON)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.C_TOT_ADV_AMT)
                    .HasColumnType("decimal(17, 2)")
                    .HasComputedColumnSql("(([ADV_AMT]+[PPN_AMT])-[PPH_AMT])", false);

                entity.Property(e => e.C_TOT_CLR_AMT)
                    .HasColumnType("decimal(18, 2)")
                    .HasComputedColumnSql("((([CLR_AMT]+[PPN_AMT])+[PPN_AMT_ON_CLR])-([PPH_AMT]+[PPH_AMT_ON_CLR]))", false);

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EMP_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EXTENSION)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NON_AP_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PPH_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPH_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPH_AMT_ON_CLR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPH_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPH_FLAG_ON_CLR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PPH_FOREIGN_AMT)
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PPH_FOREIGN_AMT_ON_CLR)
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_AMT_ON_CLR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_CREDITABLE_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PPN_CREDIT_ON_CLR_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PPN_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPN_FLAG_ON_CLR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PPN_FOREIGN_AMT)
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PPN_FOREIGN_AMT_ON_CLR)
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PPN_RATE)
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("PPN Currency Rate");

                entity.Property(e => e.PPN_RATE_CLR)
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("PPN Currency Rate");

                entity.Property(e => e.PPN_USE_BASIC_RATE_ON_ADV)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PURPOSE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.RTN_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SETTLE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<ADV_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.TYPE, e.FORM_NO, e.SEQ_NO })
                    .HasName("PK_ADV_TRN_1");

                entity.ToTable("ADV_TRN");

                entity.HasIndex(e => new { e.COY_CODE, e.FORM_NO, e.TYPE }, "IX_ADV_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CURR)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IDR_TRN_AMT)
                    .HasColumnType("decimal(31, 4)")
                    .HasComputedColumnSql("([TRN_AMT]*[CURR_RATE])", false);

                entity.Property(e => e.PPH_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TRN_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TRN_DTL)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VAT_AMT)
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AP_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.AP_NO })
                    .HasName("PK_AP_MASTER");

                entity.ToTable("AP_MST");

                entity.HasIndex(e => new { e.COY_CODE, e.DOC_NO, e.VOUCH_NO }, "IX_AP_MST");

                entity.HasIndex(e => new { e.COY_CODE, e.VOUCH_NO }, "IX_AP_MST_1");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AP_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO_AP_INVOICED)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO_AP_NOT_YET_INVOICED)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADJ_AMT_AP_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ADJ_AMT_AP_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.AP_AMT_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.AP_AMT_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BASIC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.C_BAL_AMT_AP_INVOICED)
                    .HasColumnType("decimal(18, 2)")
                    .HasComputedColumnSql("(([AP_AMT_INVOICED]+[ADJ_AMT_AP_INVOICED])-[PAY_AMT_AP_INVOICED])", false);

                entity.Property(e => e.C_BAL_AMT_AP_NOT_YET_INVOICED)
                    .HasColumnType("decimal(18, 2)")
                    .HasComputedColumnSql("(([AP_AMT_NOT_YET_INVOICED]+[ADJ_AMT_AP_NOT_YET_INVOICED])-[PAY_AMT_AP_NOT_YET_INVOICED])", false);

                entity.Property(e => e.C_TOT_AP_AMT)
                    .HasColumnType("decimal(18, 2)")
                    .HasComputedColumnSql("(([BASIC_AMT]+[PPN_AMT])+[PPH_AMT])", false);

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_AMT_AP_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PAY_AMT_AP_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PNL_CRE_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PNL_UPD_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SETTLE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SETTLE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO_TEMP)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AP_MST_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AP_MST_DEL");

                entity.Property(e => e.ACCT_NO_AP_INVOICED)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO_AP_NOT_YET_INVOICED)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADJ_AMT_AP_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ADJ_AMT_AP_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.AP_AMT_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.AP_AMT_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.AP_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BASIC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.C_BAL_AMT_AP_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.C_BAL_AMT_AP_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.C_TOT_AP_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_AMT_AP_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PAY_AMT_AP_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PNL_CRE_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PNL_DEL_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PNL_UPD_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SETTLE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SETTLE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO_TEMP)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AP_MST_FC>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.AP_NO });

                entity.ToTable("AP_MST_FC");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AP_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_ADJ_AMT_AP_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_ADJ_AMT_AP_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_AP_AMT_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_AP_AMT_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_BASIC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_BASIC_RATE).HasColumnType("decimal(16, 3)");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_PAY_AMT_AP_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PAY_AMT_AP_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPH_RATE).HasColumnType("decimal(16, 3)");

                entity.Property(e => e.CURR_PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPN_RATE).HasColumnType("decimal(16, 3)");

                entity.Property(e => e.C_CURR_BAL_AMT_AP_INVOICED)
                    .HasColumnType("decimal(18, 2)")
                    .HasComputedColumnSql("(([CURR_AP_AMT_INVOICED]+[CURR_ADJ_AMT_AP_INVOICED])-[CURR_PAY_AMT_AP_INVOICED])", false);

                entity.Property(e => e.C_CURR_BAL_AMT_AP_NOT_YET_INVOICED)
                    .HasColumnType("decimal(18, 2)")
                    .HasComputedColumnSql("(([CURR_AP_AMT_NOT_YET_INVOICED]+[CURR_ADJ_AMT_AP_NOT_YET_INVOICED])-[CURR_PAY_AMT_AP_NOT_YET_INVOICED])", false);
            });

            modelBuilder.Entity<AP_MST_FC_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AP_MST_FC_DEL");

                entity.Property(e => e.AP_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_ADJ_AMT_AP_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_ADJ_AMT_AP_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_AP_AMT_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_AP_AMT_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_BASIC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_BASIC_RATE).HasColumnType("decimal(16, 3)");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_PAY_AMT_AP_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PAY_AMT_AP_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPH_RATE).HasColumnType("decimal(16, 3)");

                entity.Property(e => e.CURR_PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPN_RATE).HasColumnType("decimal(16, 3)");

                entity.Property(e => e.C_CURR_BAL_AMT_AP_INVOICED).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.C_CURR_BAL_AMT_AP_NOT_YET_INVOICED).HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<AP_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.AP_NO, e.TRN_SEQ });

                entity.ToTable("AP_TRN");

                entity.HasIndex(e => new { e.COY_CODE, e.PRF_NO, e.TRN_TYPE, e.VOUCH_NO }, "IX_AP_TRN");

                entity.HasIndex(e => new { e.COY_CODE, e.VOUCH_NO }, "IX_AP_TRN_1");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AP_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.PRF_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AP_TRN_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AP_TRN_DEL");

                entity.Property(e => e.AP_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.PNL_DEL_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PRF_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AR_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PROC_MONTH, e.AR_NO })
                    .HasName("PK_AR_MST_1");

                entity.ToTable("AR_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADJ_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BASC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.C_TOT_AR_AMT)
                    .HasColumnType("decimal(21, 2)")
                    .HasComputedColumnSql("((((([BASC_AMT]-[DISC_AMT])+([PPN]-[RCV_PPN]))+[PPH_AMT])+[ADJ_AMT])-[RCV_AMT])", false);

                entity.Property(e => e.DISC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FOREIGN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.INV_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_NO)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PNL_UPD_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PPN).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT)
                    .HasColumnType("decimal(17, 2)")
                    .HasComputedColumnSql("([PPN]-[RCV_PPN])", false);

                entity.Property(e => e.QTY_TON).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.RCV_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RCV_PPN).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SETTLE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SETTLE_DATE).HasColumnType("datetime");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AR_MST_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AR_MST_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADJ_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.BASIC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.C_TOT_AR_AMT).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DISC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FOREIGN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.INV_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PNL_UPD_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PPN).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY_TON).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.RCV_AMT).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RCV_PPN).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SETTLE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SETTLE_DATE).HasColumnType("datetime");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AR_MST_FC>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.AR_NO });

                entity.ToTable("AR_MST_FC");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.CURR_BASIC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_BASIC_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPH_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPN_RATE).HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<AR_MST_FC_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AR_MST_FC_DEL");

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_BASIC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_BASIC_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPH_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_PPN_RATE).HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<AR_RECEIPT_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PROC_MONTH, e.AR_RECEIPT_NO });

                entity.ToTable("AR_RECEIPT_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AR_RECEIPT_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ADJ_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BAL_AMT)
                    .HasColumnType("decimal(18, 2)")
                    .HasComputedColumnSql("(([RECEIPT_AMT]+[ADJ_AMT])-[USED_AMT])", false);

                entity.Property(e => e.BATCH_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.C_TOT_RECEIPT_AMT)
                    .HasColumnType("decimal(20, 2)")
                    .HasComputedColumnSql("(((([RECEIPT_AMT]+[PPN_AMT])+[ADJ_AMT])-[USED_AMT])-[USED_PPN_AMT])", false);

                entity.Property(e => e.DEBIT_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DEBIT_TRN_CLASS)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEPOSIT_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOREIGN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_REF_NO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PNL_UPD_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RECEIPT_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RECEIPT_CTGR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RECEIPT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RECEIPT_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SETTLE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SETTLE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USED_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.USED_PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AR_RECEIPT_MST_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AR_RECEIPT_MST_DEL");

                entity.Property(e => e.ADJ_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.AR_RECEIPT_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BATCH_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.C_TOT_RECEIPT_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DEBIT_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DEBIT_TRN_CLASS)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DEPOSIT_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOREIGN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_REF_NO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PNL_UPD_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RECEIPT_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RECEIPT_CTGR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RECEIPT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RECEIPT_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SETTLE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SETTLE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USED_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.USED_PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AR_RECEIPT_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.AR_RECEIPT_NO, e.SEQ_NO });

                entity.ToTable("AR_RECEIPT_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AR_RECEIPT_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BATCH_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DEBIT_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DEBIT_TRN_CLASS)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEPOSIT_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOREIGN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_REF_NO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PNL_UPD_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RECEIPT_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RECEIPT_CTGR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RECEIPT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RECEIPT_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AR_RECEIPT_TRN_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AR_RECEIPT_TRN_DEL");

                entity.Property(e => e.AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AR_RECEIPT_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.BATCH_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DEBIT_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DEBIT_TRN_CLASS)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DEPOSIT_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FOREIGN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_REF_NO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PNL_UPD_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RECEIPT_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RECEIPT_CTGR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RECEIPT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RECEIPT_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AR_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.AR_NO, e.SEQ_NO });

                entity.ToTable("AR_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.AR_RECEIPT_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.BASC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DISC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FOREIGN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.INV_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_NO)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PNL_UPD_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY_TON).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AR_TRN_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AR_TRN_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.AR_RECEIPT_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.BASC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DISC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FOREIGN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.INV_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_NO)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PNL_UPD_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY_TON).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CIP_PROJ_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PROJ_NO })
                    .HasName("PK_CIP_PROJ_MST_1");

                entity.ToTable("CIP_PROJ_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCU_PROJ_COST).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ACCU_PROJ_COST_ADJ).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ACTIVE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASST_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BUDG_REF_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CIP_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.C_ACTIVE_CODE)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when [Active_Code]='0' then 'NOT ACTIVE' when [Active_Code]='1' then 'ACTIVE' when [Active_Code]='8' then 'FINISHED' when [Active_Code]='9' then 'CAPITALIZED' else 'UNKNOWN' end)", true);

                entity.Property(e => e.C_START_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(CONVERT([char](6),[Start_Date],(112)))", true)
                    .IsFixedLength();

                entity.Property(e => e.C_SUB_PROJ_COST)
                    .HasColumnType("decimal(16, 2)")
                    .HasComputedColumnSql("([dbo].[Get_SubProjCost]('1',[Coy_Code],[Proj_No]))", false);

                entity.Property(e => e.C_SUB_PROJ_COST_ADJ)
                    .HasColumnType("decimal(16, 2)")
                    .HasComputedColumnSql("([dbo].[Get_SubProjCost]('2',[Coy_Code],[Proj_No]))", false);

                entity.Property(e => e.FA_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FINISH_DATE).HasColumnType("date");

                entity.Property(e => e.MAIN_PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROJ_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PROJ_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.START_DATE).HasColumnType("date");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<CIP_PROJ_MST_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIP_PROJ_MST_DEL");

                entity.Property(e => e.ACCU_PROJ_COST).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ACCU_PROJ_COST_ADJ).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ACTIVE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASST_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BUDG_REF_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CIP_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.C_START_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(CONVERT([char](6),[Start_Date],(112)))", true)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.FA_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FINISH_DATE).HasColumnType("date");

                entity.Property(e => e.MAIN_PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROJ_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PROJ_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.START_DATE).HasColumnType("date");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<CIP_PROJ_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PROJ_NO, e.TRN_SEQ })
                    .HasName("PK_CIP_PROJ_TRN_1");

                entity.ToTable("CIP_PROJ_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.C_TRN_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(CONVERT([char](6),[Trn_Date],(112)))", true)
                    .IsFixedLength();

                entity.Property(e => e.C_TRN_TYPE)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when [TRN_TYPE]='NOR' then 'NORMAL' when [TRN_TYPE]='ADJ' then 'ADJUSTMENT' when [TRN_TYPE]='TRF' AND [TRN_AMT]>(0) then 'TRANSFER IN' when [TRN_TYPE]='TRF' AND [TRN_AMT]<(0) then 'TRANSFER OUT' when [TRN_TYPE]='CAP' then 'CAPITALIZE' else 'UNKNOWN' end)", true);

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CTGR)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_DATE).HasColumnType("date");

                entity.Property(e => e.TRN_DESC)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CIP_PROJ_TRN_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIP_PROJ_TRN_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.C_TRN_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.C_TRN_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CTGR)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_DATE).HasColumnType("date");

                entity.Property(e => e.TRN_DESC)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<COSTING_ACCT_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PROCESS_SEQ, e.PROCESS_SUB_SEQ, e.DATA_TYPE, e.REC_CODE, e.MAT_TYPE, e.REC_TYPE, e.CMT_TYPE, e.ACCT_NO_FROM, e.COST_CTR_FROM, e.COST_CTGR });

                entity.ToTable("COSTING_ACCT_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROCESS_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROCESS_SUB_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATA_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MAT_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.REC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CMT_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NO_FROM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR_FROM)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTGR)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ACCT_NO_FROM_DISPLAYED_IN_VCH)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NO_TO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR_TO)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GROUP_BY_ACCT_NO_FROM)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.NEED_TO_CHECK_QTY_VALUE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.PROCESS_SEQ_EXCLUDED)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PROPORTION_BY_QTY)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QUERY_FOR_AMT)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.QUERY_FOR_QTY)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.QUERY_FOR_VARIANCE)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_ITEM_DESC)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VOUCH_SEQ)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<COSTING_DATA_INPUT>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO, e.DATA_TYPE, e.DATA_TYPE_SEQ, e.REC_CODE, e.REC_KIND, e.REC_TYPE, e.WH_CODE, e.CMT_TYPE, e.BAG_TYPE, e.INPUT_TYPE });

                entity.ToTable("COSTING_DATA_INPUT");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATA_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATA_TYPE_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.REC_KIND)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.REC_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CMT_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BAG_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DATA_INPUT).HasColumnType("decimal(16, 3)");

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<COSTING_DATA_INPUT_DTL_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DATA_TYPE, e.DATA_TYPE_SEQ, e.REC_CODE, e.REC_KIND, e.REC_TYPE, e.WH_CODE });

                entity.ToTable("COSTING_DATA_INPUT_DTL_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATA_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATA_TYPE_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.REC_KIND)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.REC_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTGR)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DATA_COLUMN_DETAIL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.INPUT_COLUMN_1_DEFAULT_VAL_QUERY)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.INPUT_COLUMN_1_QUERY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_COLUMN_2_DEFAULT_VAL_QUERY)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.INPUT_COLUMN_2_QUERY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_COLUMN_3_DEFAULT_VAL_QUERY)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.INPUT_COLUMN_3_QUERY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_COLUMN_4_DEFAULT_VAL_QUERY)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.INPUT_COLUMN_4_QUERY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_COLUMN_5_DEFAULT_VAL_QUERY)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.INPUT_COLUMN_5_QUERY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_COLUMN_6_DEFAULT_VAL_QUERY)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.INPUT_COLUMN_6_QUERY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ORDER_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<COSTING_DATA_INPUT_GROUP_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DATA_TYPE, e.DATA_TYPE_SEQ, e.GROUP_NAME });

                entity.ToTable("COSTING_DATA_INPUT_GROUP_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATA_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATA_TYPE_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GROUP_NAME)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GROUP_COL_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TOTAL_GROUP_HEADER)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<COSTING_DATA_INPUT_MST_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DATA_TYPE, e.DATA_TYPE_SEQ });

                entity.ToTable("COSTING_DATA_INPUT_MST_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATA_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATA_TYPE_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATA_COLUMN_HEADER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EDITABLE_FLAG_COLUMN_6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GRID_TITLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GROUP_COLUMN_1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GROUP_COLUMN_2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GROUP_COLUMN_3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GROUP_COLUMN_4)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GROUP_COLUMN_5)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GROUP_COLUMN_6)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_COLUMN_1_HEADER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_COLUMN_2_HEADER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_COLUMN_3_HEADER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_COLUMN_4_HEADER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_COLUMN_5_HEADER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.INPUT_COLUMN_6_HEADER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PGM_TITLE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TOTAL_COLUMN_HEADER)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TOTAL_IN_THE_END_OF_ROWS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<COSTING_DOC_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO });

                entity.ToTable("COSTING_DOC_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<COSTING_ELM_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PROC_MONTH, e.PROCESS_SEQ, e.PROCESS_SUB_SEQ, e.DATA_TYPE, e.REC_CODE, e.MAT_TYPE, e.REC_TYPE, e.CMT_TYPE, e.ACCT_NO_FROM, e.COST_CTR_FROM });

                entity.ToTable("COSTING_ELM_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROCESS_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROCESS_SUB_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DATA_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MAT_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.REC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CMT_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NO_FROM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR_FROM)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NO_TO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.COST_CTGR)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR_TO)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COST_ELM)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UNIT_PRICE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<COSTING_RPT_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.RPT_ID, e.RPT_SEQ, e.RPT_ITEM_NO });

                entity.ToTable("COSTING_RPT_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RPT_ID)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RPT_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RPT_ITEM_NO)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QUERY_FOR_AMT)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.QUERY_FOR_QTY)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.RPT_FORMULA)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RPT_GROUP)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RPT_ITEM_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RPT_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UOM)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<COSTING_RPT_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.RPT_ID, e.RPT_SEQ });

                entity.ToTable("COSTING_RPT_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RPT_ID)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RPT_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DISPLAY_UNIT_PRICE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DISPLAY_UOM)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RPT_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<COSTING_RPT_SUPP_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.RPT_ID, e.RPT_SEQ, e.RPT_ITEM_NO });

                entity.ToTable("COSTING_RPT_SUPP_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RPT_ID)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RPT_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RPT_ITEM_NO)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QUERY_FOR_AMT)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.QUERY_FOR_AMT_YTD)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RPT_ITEM_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FIN_ACCT_COA>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ACCT_NO });

                entity.ToTable("FIN_ACCT_COA");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_GROUP_1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_GROUP_2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_GROUP_3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NATURE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.ACCT_TITLE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_DATE).HasColumnType("datetime");

                entity.Property(e => e.BLOCK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.C_LVL)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when right([Acct_No],(6))='000000' then '1' when right([Acct_No],(4))='0000' then '2' when right([Acct_No],(2))='00' then '3' else '4' end)", false);

                entity.Property(e => e.EFF_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EXPN_ACCT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EXP_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.OLD_CODE)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TAX_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<FIN_ACCT_EXP>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ACCT_NO, e.COST_CTR });

                entity.ToTable("FIN_ACCT_EXP");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.APPRV_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_DATE).HasColumnType("datetime");

                entity.Property(e => e.BLOCK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EFF_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EXP_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<FIN_ACCT_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.REC_TYPE, e.VOUCH_SEQ, e.STEP_NO });

                entity.ToTable("FIN_ACCT_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_TYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_SEQ)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO_IN)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NO_OUT)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR_IN)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR_OUT)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_REMARK)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FIN_COST_BUDGET>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.COST_CTR, e.ACCT_NO, e.YEAR, e.MONTH })
                    .HasName("PK_FIN_COST_BUDGET_1");

                entity.ToTable("FIN_COST_BUDGET");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.REV_DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<FIN_COST_BUDGET_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIN_COST_BUDGET_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.REV_DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_COST_BUDGET_REV>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.REV_ID });

                entity.ToTable("FIN_COST_BUDGET_REV");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REV_ID).ValueGeneratedOnAdd();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OLD_REV_DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.REV_BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_COST_BUDGET_REV_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIN_COST_BUDGET_REV_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OLD_REV_DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.REV_BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_COST_BUDGET_SUPP>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.YEAR, e.ACCT_NO, e.COST_CTR, e.ITEM_IDX })
                    .HasName("PK_FIN_COST_BUDGET_SUPP_1");

                entity.ToTable("FIN_COST_BUDGET_SUPP");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FREQ).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.ITEM_DESC)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REMARK).IsUnicode(false);

                entity.Property(e => e.REMARK_2).IsUnicode(false);

                entity.Property(e => e.TOTAL_MONTH).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TOTAL_YEAR).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.UOM)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<FIN_COST_BUDGET_SUPP_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIN_COST_BUDGET_SUPP_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FREQ).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.ITEM_DESC)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REMARK).IsUnicode(false);

                entity.Property(e => e.REMARK_2).IsUnicode(false);

                entity.Property(e => e.TOTAL_MONTH).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TOTAL_YEAR).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UOM)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_COST_BUDGET_SUPP_TTV>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.BUDG_ID });

                entity.ToTable("FIN_COST_BUDGET_SUPP_TTV");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_ID).ValueGeneratedOnAdd();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FREQ).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.ITEM_DESC)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REMARK).IsUnicode(false);

                entity.Property(e => e.REMARK_2).IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TOTAL_MONTH).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TOTAL_YEAR).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UOM)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_COST_BUDGET_SUPP_TTV_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIN_COST_BUDGET_SUPP_TTV_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FREQ).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.ITEM_DESC)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REMARK).IsUnicode(false);

                entity.Property(e => e.REMARK_2).IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TOTAL_MONTH).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TOTAL_YEAR).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UOM)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_COST_BUDGET_TTV>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.BUDG_ID });

                entity.ToTable("FIN_COST_BUDGET_TTV");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_ID).ValueGeneratedOnAdd();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_COST_BUDGET_TTV_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIN_COST_BUDGET_TTV_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_COST_CTR>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.COST_CTR })
                    .HasName("PK_FIN_COST_CTR_1");

                entity.ToTable("FIN_COST_CTR");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BLOCK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.COST_CTGR)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.COST_CTR_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COST_GROUP_1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOCT_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROJECT_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<FIN_COST_ELM_LEDG>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.YEAR, e.MONTH, e.COST_CTR, e.ACCT_NO, e.COST_ELM });

                entity.ToTable("FIN_COST_ELM_LEDG");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_ELM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BAL_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.CR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.NET_AMT)
                    .HasColumnType("decimal(17, 2)")
                    .HasComputedColumnSql("([dr_amt]-[cr_amt])", false);
            });

            modelBuilder.Entity<FIN_COST_ELM_TRN>(entity =>
            {
                entity.ToTable("FIN_COST_ELM_TRN");

                entity.Property(e => e.ACCT_NO_IN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO_OUT)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.COST_CTR_IN)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR_OUT)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COST_ELM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNIT_PRICE).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_EXP_LEDG>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.YEAR, e.MONTH, e.ACCT_NO, e.COST_CTR });

                entity.ToTable("FIN_EXP_LEDG");

                entity.HasIndex(e => new { e.COY_CODE, e.UNTT, e.YEAR, e.MONTH, e.ACCT_NO }, "IX_FIN_EXP_LEDG");

                entity.HasIndex(e => new { e.COY_CODE, e.ACCT_NO, e.COST_CTR, e.YEAR, e.MONTH }, "IX_FIN_EXP_LEDG2");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BAL_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BUDG_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.CR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.NET_AMT)
                    .HasColumnType("decimal(17, 2)")
                    .HasComputedColumnSql("([dr_amt]-[cr_amt])", false);
            });

            modelBuilder.Entity<FIN_GEN_LEDG>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.YEAR, e.MONTH, e.ACCT_NO });

                entity.ToTable("FIN_GEN_LEDG");

                entity.HasIndex(e => new { e.COY_CODE, e.YEAR, e.ACCT_NO, e.MONTH }, "IX_FIN_GEN_LEDG");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BAL_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BUDG_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.CR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.NET_AMT)
                    .HasColumnType("decimal(17, 2)")
                    .HasComputedColumnSql("([DR_AMT]-[CR_AMT])", false);
            });

            modelBuilder.Entity<FIN_GRP_COA>(entity =>
            {
                entity.HasKey(e => e.ACCT_NO)
                    .HasName("PK_FIN_ACCT_COA_REF_1");

                entity.ToTable("FIN_GRP_COA");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_GROUP_1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_GROUP_2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_GROUP_3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NATURE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.ACCT_TITLE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_DATE).HasColumnType("datetime");

                entity.Property(e => e.BLOCK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.C_LVL)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when right([Acct_No],(6))='000000' then '1' when right([Acct_No],(4))='0000' then '2' when right([Acct_No],(2))='00' then '3' else '4' end)", false);

                entity.Property(e => e.EFF_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EXPN_ACCT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EXP_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.OLD_CODE)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TAX_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<FIN_GRP_CODE>(entity =>
            {
                entity.HasKey(e => new { e.GROUP_TYPE, e.GROUP_CODE });

                entity.ToTable("FIN_GRP_CODE");

                entity.Property(e => e.GROUP_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GROUP_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BOLD_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GROUP_TITLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPDATE_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')")
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<FIN_ILT_REF>(entity =>
            {
                entity.HasKey(e => new { e.UNTT_SEND, e.UNTT_RECV, e.ACCT_NO });

                entity.ToTable("FIN_ILT_REF");

                entity.Property(e => e.UNTT_SEND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT_RECV)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CNTR_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_QUERY>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.REC_CODE, e.PAYEE_TYPE });

                entity.ToTable("FIN_QUERY");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.DATA_TEXT)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.DATA_TITLE_TEXT)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DATA_VALUE)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.KEY_FIELD)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.REC_TITLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TABLE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FIN_TRN_CODE>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.TRN_CODE, e.GROUP_CODE });

                entity.ToTable("FIN_TRN_CODE");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GROUP_CODE)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BLOCK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GROUP_TITLE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<FIN_VCH_ILT>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.YEAR, e.MONTH, e.VOUCH_NO, e.ILT_SEQ });

                entity.ToTable("FIN_VCH_ILT");

                entity.HasIndex(e => new { e.COY_CODE, e.VOUCH_NO }, "IX_FIN_VCH_ILT");

                entity.HasIndex(e => new { e.COY_CODE, e.CORR_VOUCH_NO }, "IX_FIN_VCH_ILT_1");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ILT_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COMPLETE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COMPLETE_TIME).HasColumnType("datetime");

                entity.Property(e => e.CORR_VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CR_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.DR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DR_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_VCH_ITM>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.VOUCH_NO, e.VOUCH_ITEM });

                entity.ToTable("FIN_VCH_ITM");

                entity.HasIndex(e => new { e.COY_CODE, e.C_VOUCH_MONTH, e.UNTT, e.APPRV_BY, e.VOUCH_TYPE }, "IX_FIN_VCH_ITM");

                entity.HasIndex(e => new { e.COY_CODE, e.C_PAID_MONTH, e.UNTT }, "IX_FIN_VCH_ITM_1");

                entity.HasIndex(e => new { e.COY_CODE, e.C_VOUCH_MONTH, e.ACCT_NO }, "IX_FIN_VCH_ITM_2");

                entity.HasIndex(e => new { e.COY_CODE, e.UNTT, e.VOUCH_DATE, e.ACCT_NO, e.APPRV_BY, e.VOUCH_TYPE }, "IX_FIN_VCH_ITM_3");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_DATE).HasColumnType("datetime");

                entity.Property(e => e.AUTO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BANK_PAID_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BANK_REF_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CHECKED_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CHECKED_DATE).HasColumnType("datetime");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CR_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.C_PAID_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([Bank_Paid_Date],(6)))", true);

                entity.Property(e => e.C_VOUCH_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([Vouch_Date],(6)))", true);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.DR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DR_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REF_SUB_SYSTEM)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.REF_SYSTEM)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_VCH_ITM_DEL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.VOUCH_NO, e.CNCL_CNTR, e.VOUCH_ITEM });

                entity.ToTable("FIN_VCH_ITM_DEL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CNCL_CNTR)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_DATE).HasColumnType("datetime");

                entity.Property(e => e.AUTO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BANK_PAID_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BANK_REF_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CHECKED_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CHECKED_DATE).HasColumnType("datetime");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CR_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.C_VOUCH_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([Vouch_Date],(6)))", true);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.DR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DR_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REF_SUB_SYSTEM)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.REF_SYSTEM)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FIN_VCH_RMK>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.VOUCH_NO });

                entity.ToTable("FIN_VCH_RMK");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHECKED_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CHECKED_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHEQUE_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAYEE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RECEIVE_BY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.REMARKS)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.REV_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_BANK)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FIN_VCH_RMK_DEL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.VOUCH_NO, e.CNCL_CNTR });

                entity.ToTable("FIN_VCH_RMK_DEL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CNCL_CNTR)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACTV_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACTV_TIME).HasColumnType("datetime");

                entity.Property(e => e.APPRV_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHECKED_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CHECKED_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHEQUE_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CNCL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CNCL_TIME)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAYEE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RECEIVE_BY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.REMARKS)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.REV_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_BANK)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FIN_VCH_TAKE>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.VOUCH_NO, e.VOUCH_ITEM });

                entity.ToTable("FIN_VCH_TAKE");

                entity.HasIndex(e => new { e.COY_CODE, e.MODULE, e.VOUCH_DATE }, "IX_FIN_VCH_TAKE");

                entity.HasIndex(e => new { e.COY_CODE, e.MODULE, e.CORR_VOUCH_NO }, "IX_FIN_VCH_TAKE_1");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CORR_VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.MODULE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FRS_RPT_LINE>(entity =>
            {
                entity.HasKey(e => new { e.RPT_ID, e.LINE_NO });

                entity.ToTable("FRS_RPT_LINE");

                entity.HasIndex(e => new { e.RPT_ID, e.LINE_TYPE, e.LINE_NO }, "IX_FRS_RPT_LINE");

                entity.Property(e => e.RPT_ID)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LINE_TEXT)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OTHER_TEXT).HasMaxLength(100);
            });

            modelBuilder.Entity<FRS_RPT_LINE_CALC>(entity =>
            {
                entity.HasKey(e => new { e.RPT_ID, e.LINE_NO, e.SEQ_NO });

                entity.ToTable("FRS_RPT_LINE_CALC");

                entity.Property(e => e.RPT_ID)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OP)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FRS_RPT_LINE_DTL>(entity =>
            {
                entity.HasKey(e => new { e.RPT_ID, e.LINE_NO, e.SEQ_NO });

                entity.ToTable("FRS_RPT_LINE_DTL");

                entity.Property(e => e.RPT_ID)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NO_FROM)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ACCT_NO_TO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_FROM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_TO)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT_FROM)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT_TO)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FRS_RPT_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.RPT_NAME });

                entity.ToTable("FRS_RPT_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RPT_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RPT_HEADER).HasMaxLength(100);

                entity.Property(e => e.RPT_ID)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FXA_ACCT_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ACCT_NO })
                    .HasName("PK_FXA_ACCT_REF_1");

                entity.ToTable("FXA_ACCT_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO_CR)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO_DR_PROD)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO_DR_SUPP)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CIP_PREOPS_CTGR)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<FXA_ASST_DEF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ASST_NO });

                entity.ToTable("FXA_ASST_DEF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASST_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACQ_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASST_LOCT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ASST_SPEC)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.FA_GRP)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ITEM_SPEC)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MIS_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ORIG_VAL).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PROJ_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SERIAL_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FXA_ASST_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PROC_MONTH, e.ASST_NO, e.UNTT, e.PLAN_CODE, e.DEPT_CODE, e.COST_CTR, e.STAT_CODE });

                entity.ToTable("FXA_ASST_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASST_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACC_DEPR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ACC_DEPR_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ASST_VAL).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ASST_VAL_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.C_NET_VAL)
                    .HasColumnType("decimal(17, 2)")
                    .HasComputedColumnSql("(([ASST_VAL]+[ASST_VAL_ADJ])-([ACC_DEPR]+[ACC_DEPR_ADJ]))", false);

                entity.Property(e => e.DISPOSE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LIFE_YEAR).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MTHLY_DEPR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MTHLY_DEPR_CIP).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.QTY).HasColumnType("decimal(8, 0)");
            });

            modelBuilder.Entity<FXA_ASST_MST_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FXA_ASST_MST_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACC_DEPR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ACC_DEPR_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ACQ_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASST_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASST_SPEC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ASST_VAL).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ASST_VAL_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DISPOSE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ITEM_SPEC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LIFE_YEAR).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MIS_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MTHLY_DEPR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ORIG_VAL).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROJ_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QTY).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.SERIAL_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FXA_ASST_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO });

                entity.ToTable("FXA_ASST_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO_IN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACC_DEPR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ACC_DEPR_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ASST_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASST_VAL).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ASST_VAL_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR_IN)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPT_CODE_IN)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DISPOSE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LIFE_YEAR).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE_IN)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT_IN)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FXA_ASST_TRN_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FXA_ASST_TRN_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO_IN)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACC_DEPR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ACC_DEPR_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ASST_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASST_VAL).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ASST_VAL_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR_IN)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPT_CODE_IN)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DISPOSE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LIFE_YEAR).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE_IN)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY).HasColumnType("decimal(8, 0)");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT_IN)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FXA_FA_CTGR>(entity =>
            {
                entity.HasKey(e => new { e.KIND_NO, e.SUB_KIND_NO });

                entity.ToTable("FXA_FA_CTGR");

                entity.Property(e => e.KIND_NO)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SUB_KIND_NO)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BLOCK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.KIND_DESC)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<FXA_FA_GRP>(entity =>
            {
                entity.HasKey(e => new { e.GROUP_TYPE, e.GROUP_CODE });

                entity.ToTable("FXA_FA_GRP");

                entity.Property(e => e.GROUP_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GROUP_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.GROUP_TITLE)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LIFE_YEAR).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<FXA_TRN_CODE>(entity =>
            {
                entity.HasKey(e => new { e.TRN_GROUP, e.TRN_CODE });

                entity.ToTable("FXA_TRN_CODE");

                entity.Property(e => e.TRN_GROUP)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.TRN_DESC)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_GROUP_DESC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_ADDR>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_ADDR");

                entity.Property(e => e.ADDR1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ADDR2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ADDR_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CITY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OWNERSHIP_STAT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.POSTAL_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROVINCE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_ADDR_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_ADDR_DEL");

                entity.Property(e => e.ADDR1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ADDR2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ADDR_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CITY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COUNTRY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DELBY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OWNERSHIP_STAT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.POSTAL_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROVINCE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_CERTIFICATE>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_CERTIFICATE");

                entity.Property(e => e.CERT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CERT_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CERT_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CERT_PROVIDER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CERT_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EXPIRED_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RESULT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_CERTIFICATE_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_CERTIFICATE_DEL");

                entity.Property(e => e.CERT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CERT_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CERT_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CERT_PROVIDER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CERT_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EXPIRED_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RESULT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_EDUCATION>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_EDUCATION");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EDU_ENTITY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EDU_LEVEL)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FINAL_SCORE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FROM_YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GRADUATION_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SUBJECT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TO_YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_EDUCATION_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_EDUCATION_DEL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.EDU_ENTITY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EDU_LEVEL)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FINAL_SCORE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FROM_YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GRADUATION_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SUBJECT)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TO_YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_FAMILY>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_FAMILY");

                entity.Property(e => e.ADDR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DATE_OF_BIRTH)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ID_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ID_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PLACE_OF_BIRTH)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RELATIONSHIP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RELIGION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_FAMILY_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_FAMILY_DEL");

                entity.Property(e => e.ADDR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DATE_OF_BIRTH)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ID_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ID_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PLACE_OF_BIRTH)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RELATIONSHIP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RELIGION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_PERSONAL_INFO>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_PERSONAL_INFO");

                entity.Property(e => e.BLOOD_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BPJSTK_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BPJS_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DATE_OF_BIRTH)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ID_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ID_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MARITAL_STATUS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NATIONALITY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NPWP_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PLACE_OF_BIRTH)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RELIGION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_PERSONAL_INFO_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_PERSONAL_INFO_DEL");

                entity.Property(e => e.BLOOD_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BPJSTK_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BPJS_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DATE_OF_BIRTH)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ID_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ID_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MARITAL_STATUS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NATIONALITY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NPWP_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PLACE_OF_BIRTH)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RELIGION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_PREV_EMPLOYMENT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_PREV_EMPLOYMENT");

                entity.Property(e => e.COMPANY_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JOIN_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LAST_POSITION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RESIGN_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_PREV_EMPLOYMENT_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_PREV_EMPLOYMENT_DEL");

                entity.Property(e => e.COMPANY_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.JOIN_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LAST_POSITION)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RESIGN_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_RELATION>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_RELATION");

                entity.Property(e => e.ADDR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RELATIONSHIP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_RELATION_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_RELATION_DEL");

                entity.Property(e => e.ADDR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RELATIONSHIP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_SKILL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_SKILL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SKILL_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKILL_PROFICIENCY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKILL_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<HRS_EMP_SKILL_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRS_EMP_SKILL_DEL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SKILL_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKILL_PROFICIENCY)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKILL_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<INV_ACCT_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ITEM_NO });

                entity.ToTable("INV_ACCT_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EXP_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_IN_TRANSIT_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<INV_ADJ_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ADJ_NO, e.ADJ_ITEM });

                entity.ToTable("INV_ADJ_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADJ_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADJ_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.AMT_IDR)
                    .HasColumnType("decimal(15, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.INV_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.RACK_LOCT)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UNIT_PRICE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<INV_ADJ_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ADJ_NO });

                entity.ToTable("INV_ADJ_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADJ_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADJ_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ADJ_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADJ_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('IDR')")
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE)
                    .HasColumnType("decimal(15, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PURPOSE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.REASON)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<INV_GAR_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.GAR_NO, e.GAR_ITEM });

                entity.ToTable("INV_GAR_DTL");

                entity.HasIndex(e => new { e.COY_CODE, e.ITEM_NO }, "IX_INV_GAR_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GAR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GAR_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ARRIVAL_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.CHARGED_ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GRR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GTR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.PROBLEM_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.PR_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RECEIVE_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.REJECT_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UNIT_PRICE).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<INV_GAR_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.GAR_NO });

                entity.ToTable("INV_GAR_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GAR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AP_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.AP_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ARRIVAL_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ARRIVAL_SEQ)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DO_NO)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.GAR_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.GAR_AMT_IDR)
                    .HasColumnType("decimal(31, 5)")
                    .HasComputedColumnSql("(round([GAR_AMT]*[CURR_RATE],(2)))", false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_AMT_IDR)
                    .HasColumnType("decimal(31, 5)")
                    .HasComputedColumnSql("(round([PPN_AMT]*[CURR_RATE],(2)))", false);

                entity.Property(e => e.PPN_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RELATED_INV_ITEMS_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TOT_GAR_AMT)
                    .HasColumnType("decimal(16, 2)")
                    .HasComputedColumnSql("([GAR_AMT]+[PPN_AMT])", false);

                entity.Property(e => e.TOT_GAR_AMT_IDR)
                    .HasColumnType("decimal(32, 5)")
                    .HasComputedColumnSql("(round(([GAR_AMT]+[PPN_AMT])*[CURR_RATE],(2)))", false);

                entity.Property(e => e.TRANSPORT_OTHER_LOCT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<INV_GRR_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.GRR_NO, e.GRR_ITEM });

                entity.ToTable("INV_GRR_DTL");

                entity.HasIndex(e => new { e.COY_CODE, e.ITEM_NO }, "IX_INV_GRR_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GRR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GRR_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CHARGED_ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RACK_LOCT)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RCV_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UNIT_PRICE).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<INV_GRR_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.GRR_NO });

                entity.ToTable("INV_GRR_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GRR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AP_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.AP_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.COMPLETED_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GRR_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.GRR_AMT_IDR)
                    .HasColumnType("decimal(31, 5)")
                    .HasComputedColumnSql("(round([GRR_AMT]*[CURR_RATE],(2)))", false);

                entity.Property(e => e.GRR_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_AMT_IDR)
                    .HasColumnType("decimal(31, 5)")
                    .HasComputedColumnSql("(round([PPN_AMT]*[CURR_RATE],(2)))", false);

                entity.Property(e => e.PPN_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RECEIVED_IN)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RELATED_INV_ITEMS_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TOT_GRR_AMT)
                    .HasColumnType("decimal(16, 2)")
                    .HasComputedColumnSql("([GRR_AMT]+[PPN_AMT])", false);

                entity.Property(e => e.TOT_GRR_AMT_IDR)
                    .HasColumnType("decimal(32, 5)")
                    .HasComputedColumnSql("(round(([GRR_AMT]+[PPN_AMT])*[CURR_RATE],(2)))", false);

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<INV_GTR_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.GTR_NO, e.GAR_NO, e.GAR_ITEM });

                entity.ToTable("INV_GTR_DTL");

                entity.HasIndex(e => new { e.COY_CODE, e.GAR_NO, e.GAR_ITEM }, "IX_INV_GTR_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GTR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GAR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GAR_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ARRIVAL_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.GRR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GTR_QTY)
                    .HasColumnType("decimal(15, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GTR_QTY_FINAL_RCV)
                    .HasColumnType("decimal(15, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GTR_QTY_TRANSIT)
                    .HasColumnType("decimal(15, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.PR_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<INV_GTR_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.GTR_NO });

                entity.ToTable("INV_GTR_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GTR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ARRIVED_AT)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REF_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRANSPORT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRANSPORT_TO)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<INV_ITEM_MST>(entity =>
            {
                entity.HasKey(e => e.ITEM_NO);

                entity.ToTable("INV_ITEM_MST");

                entity.HasIndex(e => new { e.CLEAN_PART_NO, e.PRICE }, "IX_INV_ITEM_MST");

                entity.HasIndex(e => e.PART_NO, "IX_PART_NO")
                    .IsUnique();

                entity.Property(e => e.BAR_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CLEAN_PART_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.EFF_PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ITEM_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_GROUP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PART_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PRICE_HIST_1).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PRICE_HIST_2).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.QTY).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<INV_ITEM_PURCHASER_RELATED_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ITEM_NO, e.UNTT, e.PLAN_CODE });

                entity.ToTable("INV_ITEM_PURCHASER_RELATED_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PURCHASER_EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<INV_KIND_REF>(entity =>
            {
                entity.HasKey(e => new { e.INV_KIND, e.INV_SUB_KIND });

                entity.ToTable("INV_KIND_REF");

                entity.Property(e => e.INV_KIND)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_SUB_KIND)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BLOCK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.INV_KIND_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<INV_MIR_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.MIR_NO, e.MIR_ITEM });

                entity.ToTable("INV_MIR_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MIR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MIR_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_STD_CONVERT_UOM).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.COY_STD_INV_ITEM_STATUS)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.COY_STD_IS_SERVICE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.COY_STD_ITEM_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.COY_STD_ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_STD_MINIMUM_STOCK)
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.COY_STD_PURCHASE_UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.COY_STD_QTY_RCV_TOLERANCE_LIMIT).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.COY_STD_USAGE_UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS_ITEM)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("('N' for New, 'E' for Existing)");

                entity.Property(e => e.USER_CONVERT_UOM).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.USER_INV_ITEM_STATUS)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.USER_IS_SERVICE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.USER_ITEM_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.USER_MINIMUM_STOCK)
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.USER_PURCHASE_UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.USER_QTY_RCV_TOLERANCE_LIMIT).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.USER_USAGE_UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<INV_MIR_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.MIR_NO });

                entity.ToTable("INV_MIR_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MIR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CREATED_TO_COY_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GEN_DESC)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MIR_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USED_FOR_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USED_FOR_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USED_FOR_UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<INV_MIS_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.MIS_NO, e.MIS_ITEM });

                entity.ToTable("INV_MIS_DTL");

                entity.HasIndex(e => new { e.COY_CODE, e.MIS_NO }, "IDX_COY_MIS_NO");

                entity.HasIndex(e => new { e.COY_CODE, e.ITEM_NO }, "IX_INV_MIS_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MIS_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MIS_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DEBIT_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.INV_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.RACK_LOCT)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UNIT_PRICE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<INV_MIS_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.MIS_NO });

                entity.ToTable("INV_MIS_MST");

                entity.HasIndex(e => new { e.COY_CODE, e.MIS_NO }, "IDX_COY_MIS_NO");

                entity.HasIndex(e => new { e.WH_CODE, e.STAT_CODE }, "IDX_WH_STAT_CODE");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MIS_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MIS_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MIS_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PICK_UP_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PICK_UP_STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("0 for ready to be picked up; 1 for in the process of being picked up; 2 for complete picked up");

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USED_FOR_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USED_FOR_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USED_FOR_UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<INV_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ITEM_NO });

                entity.ToTable("INV_MST");

                entity.HasIndex(e => new { e.COY_CODE, e.ACTIVE_CODE, e.ITEM_NO }, "IX_INV_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACTIVE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAR_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONVERT_UOM).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.IS_SERVICE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ITEM_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_GROUP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_STATUS)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MINIMUM_STOCK)
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PART_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PURCHASE_UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PURCH_EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.QC_NEEDED)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.QTY_RCV_TOLERANCE_LIMIT)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Percentage of tolerance for goods receipt (can be over or under) against PO quantity");

                entity.Property(e => e.SUPP_REF_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("SUPPLIER'S REFERENCE NO. FOR THIS PARTICULAR ITEM");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USAGE_UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<INV_MST_HIST>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INV_MST_HIST");

                entity.Property(e => e.ACTIVE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAR_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONVERT_UOM).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.IS_SERVICE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ITEM_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_GROUP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ITEM_STATUS)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MINIMUM_STOCK)
                    .HasColumnType("decimal(10, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PART_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PURCHASE_UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PURCH_EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.QC_NEEDED)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.QTY_RCV_TOLERANCE_LIMIT).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SUPP_REF_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USAGE_UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<INV_RAW_MAT_DPCH_ST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PO_NO, e.PO_ITEM, e.ASSIGN_SEQ });

                entity.ToTable("INV_RAW_MAT_DPCH_STS");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASSIGN_SEQ)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DELV_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DPCH_STAG_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DPCH_STAG_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GAR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<INV_STOCK>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ITEM_NO, e.WH_CODE });

                entity.ToTable("INV_STOCK");

                entity.HasIndex(e => new { e.COY_CODE, e.WH_CODE, e.ITEM_NO }, "IX_INV_STOCK");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AVG_PRICE)
                    .HasColumnType("decimal(34, 18)")
                    .HasComputedColumnSql("(case when [BAL_QTY]<>(0) then round([BAL_AMT]/[BAL_QTY],(2)) else (0) end)", false);

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BAL_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.MM_AMT_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MM_AMT_ISU).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MM_AMT_RCV).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MM_QTY_ADJ).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.MM_QTY_ISU).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.MM_QTY_RCV).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.RACK_LOCT)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.YTD_AMT_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.YTD_AMT_ISU).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.YTD_AMT_RCV).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.YTD_QTY_ADJ).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.YTD_QTY_ISU).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.YTD_QTY_RCV).HasColumnType("decimal(15, 3)");
            });

            modelBuilder.Entity<INV_STOCK_MONTH>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ITEM_NO, e.WH_CODE, e.PROC_MONTH });

                entity.ToTable("INV_STOCK_MONTH");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AVG_PRICE).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BAL_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.MM_AMT_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MM_AMT_ISU).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MM_AMT_RCV).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MM_QTY_ADJ).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.MM_QTY_ISU).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.MM_QTY_RCV).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.RACK_LOCT)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YTD_AMT_ADJ).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.YTD_AMT_ISU).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.YTD_AMT_RCV).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.YTD_QTY_ADJ).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.YTD_QTY_ISU).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.YTD_QTY_RCV).HasColumnType("decimal(15, 3)");
            });

            modelBuilder.Entity<INV_UOM>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UOM_CODE });

                entity.ToTable("INV_UOM");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UOM_CODE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.UOM_DESC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<INV_VMR_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.VMR_NO, e.VMR_ITEM });

                entity.ToTable("INV_VMR_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VMR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VMR_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACTIVE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BANK_AC_NAME)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_AC_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BELONG_TO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_CODE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CONT_PERS_NM1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONT_PERS_NM2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONT_PERS_NM3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CTRY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEST_CODE)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MOBILE_NO1)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MOBILE_NO2)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MOBILE_NO3)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NPWP_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_ADDR1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_ADDR2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_ADDR3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_FAX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NAME)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_PHONE1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_PHONE2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TELEX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PKP_NO)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ZIP_CODE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<INV_VMR_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.VMR_NO });

                entity.ToTable("INV_VMR_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VMR_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CREATED_TO_COY_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GEN_DESC)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USED_FOR_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USED_FOR_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USED_FOR_UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VENDOR_TYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VMR_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<INV_WAREHOUSE>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.WH_CODE })
                    .HasName("PK_INV_WAREHOUSE_1");

                entity.ToTable("INV_WAREHOUSE");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADDR_1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ADDR_2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ADDR_3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WH_DESCRIPTION)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MKT_DEST_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.AREA_CODE, e.ZONE_CODE, e.DEST_CODE });

                entity.ToTable("MKT_DEST_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AREA_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZONE_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DEST_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEST_NAME)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LVL_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_DPCH_LOCT>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DPCH_LOCT })
                    .HasName("PK_MKT_WAREHOUSE");

                entity.ToTable("MKT_DPCH_LOCT");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DPCH_LOCT)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AREA_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEST_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DPCH_ADD1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DPCH_ADD2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DPCH_ADD3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DPCH_LOCT_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DPCH_TYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.ZONE_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MKT_DPCH_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.EFF_DATE, e.DPCH_LOCT, e.PROD_CODE, e.DPCH_STAG_CODE })
                    .HasName("PK_MKT_DPCH_REF_1");

                entity.ToTable("MKT_DPCH_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EFF_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DPCH_LOCT)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DPCH_STAG_DESC)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DPCH_STAG_ROLE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_DPCH_STG>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.SDO_NO, e.DPCH_STAG_CODE, e.DPCH_STAG_SEQ });

                entity.ToTable("MKT_DPCH_STG");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DELV_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_QLT_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MANUAL)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MANUAL_REASON)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MOISTURE).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QTY_DRY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QTY_UOM)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.QTY_WET).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VSL_TUG_CODE)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MKT_DPCH_STG_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MKT_DPCH_STG_DEL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DELV_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_QLT_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MANUAL)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MANUAL_REASON)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MOISTURE).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QTY_DRY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QTY_UOM)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.QTY_WET).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VSL_TUG_CODE)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MKT_INV_FAKTUR>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.TRN_CODE, e.STAT_CODE, e.BRANCH_CODE, e.INV_YEAR, e.SEQ_NO });

                entity.ToTable("MKT_INV_FAKTUR");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BRANCH_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_YEAR)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SEQ_NO).ValueGeneratedOnAdd();

                entity.Property(e => e.ACTIVE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.END_IDX).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.LAST_IDX).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.START_IDX).HasColumnType("decimal(9, 0)");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_INV_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.INV_NO })
                    .HasName("PK_INV_MST_1");

                entity.ToTable("MKT_INV_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.ACD_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ACW_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ADJ_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ADJ_AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.AR_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AR_POST_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AR_POST_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AR_POST_TIME)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAG_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BASC_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BASC_AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BRAND_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_PPH_RATE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CURR_PPN_RATE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CUST_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DELV_ADD1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_CTRY)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DELV_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DISC_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DISC_AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_AMT)
                    .HasColumnType("decimal(19, 2)")
                    .HasComputedColumnSql("(((([BASC_AMT]+[ADJ_AMT])-[DISC_AMT])+[PPN_AMT])+[PPH_AMT])", false);

                entity.Property(e => e.INV_AMT_IDR)
                    .HasColumnType("decimal(19, 2)")
                    .HasComputedColumnSql("(((([BASC_AMT_IDR]+[ADJ_AMT_IDR])-[DISC_AMT_IDR])+[PPN_AMT_IDR])+[PPH_AMT_IDR])", false);

                entity.Property(e => e.INV_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_FAKTUR)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.ORDER_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PACK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_COND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PORT_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPH_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPH_AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PRICE_DIST).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PRINT_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRINT_DATE).HasColumnType("datetime");

                entity.Property(e => e.PRINT_FAKTUR_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRINT_FAKTUR_DATE).HasColumnType("datetime");

                entity.Property(e => e.PROD_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY_UOM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SALES_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MKT_INV_MST_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MKT_INV_MST_DEL");

                entity.Property(e => e.ACD_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ACW_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ADJ_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ADJ_AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.AR_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AR_POST_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AR_POST_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AR_POST_TIME)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAG_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BASC_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BASC_AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BRAND_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_PPH_RATE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CURR_PPN_RATE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CUST_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DELV_ADD1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_CTRY)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DELV_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DISC_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DISC_AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.INV_AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.INV_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_FAKTUR)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.INV_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.ORDER_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PACK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_COND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PORT_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPH_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPH_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPH_AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PRICE_DIST).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PRINT_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRINT_DATE).HasColumnType("datetime");

                entity.Property(e => e.PRINT_FAKTUR_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRINT_FAKTUR_DATE).HasColumnType("datetime");

                entity.Property(e => e.PROD_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY_UOM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SALES_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MKT_INV_SPEC>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.INV_NO, e.SPEC_TYPE, e.SPEC_SEQ, e.SPEC_ITEM });

                entity.ToTable("MKT_INV_SPEC");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INV_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SPEC_TYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_SEQ).ValueGeneratedOnAdd();

                entity.Property(e => e.SPEC_ITEM)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.SPEC_RESULT)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_VALUE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_VALUE_Max)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_VALUE_Min)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_INV_SPEC_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MKT_INV_SPEC_DEL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.INV_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SPEC_ITEM)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_RESULT)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_TYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_VALUE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_VALUE_Max)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_VALUE_Min)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_MDO>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.MDO_NO })
                    .HasName("PK_MKT_MDO_MST");

                entity.ToTable("MKT_MDO");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MDO_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BAG_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BRAND_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CONTRACT_NO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CUST_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.C_QTY_OUTS_TON)
                    .HasColumnType("decimal(13, 3)")
                    .HasComputedColumnSql("([QTY_TON]-([QTY_DELV]+[QTY_OTW]))", false);

                entity.Property(e => e.DELV_ADD1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_CTRY)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DPCH_LOCT)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EXP_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FRGHT_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MDO_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OPEN_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ORDER_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PACK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PRICE_DIST).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PROD_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.QTY_BAG).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QTY_DELV).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QTY_OTW).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QTY_TON).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SALES_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UOM)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_MDO_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MKT_MDO_DEL");

                entity.Property(e => e.BAG_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BRAND_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CONTRACT_NO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CUST_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.C_QTY_OUTS_TON).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.DELV_ADD1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_CTRY)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DPCH_LOCT)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EXP_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FRGHT_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MDO_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MDO_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OPEN_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ORDER_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PACK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PRICE_DIST).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PROD_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.QTY_BAG).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QTY_DELV).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QTY_OTW).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QTY_TON).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SALES_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UOM)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_MDO_SPEC>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.MDO_NO, e.SPEC_TYPE, e.SPEC_ITEM, e.SPEC_SEQ });

                entity.ToTable("MKT_MDO_SPEC");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MDO_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SPEC_TYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_ITEM)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_SEQ).ValueGeneratedOnAdd();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.SPEC_UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_VALUE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_MDO_SPEC_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MKT_MDO_SPEC_DEL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MDO_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SPEC_ITEM)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_TYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SPEC_VALUE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_PACKING>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PACK_CODE, e.BRAND_CODE, e.BAG_TYPE });

                entity.ToTable("MKT_PACKING");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PACK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BRAND_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAG_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAG_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BAG_SIZE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BRAND_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.PACK_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PACK_UOM)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_PORT_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PORT_CODE });

                entity.ToTable("MKT_PORT_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PORT_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.PORT_CTRY)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PORT_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_PROD_TYPE>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PROD_TYPE })
                    .HasName("PK_MKT_PROD_TYPE_1");

                entity.ToTable("MKT_PROD_TYPE");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.LONG_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PROD_GROUP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PROD_NAME)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<MKT_SDO>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.SDO_NO });

                entity.ToTable("MKT_SDO");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACD_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ACW_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.BAG_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BRAND_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CUST_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_CTRY)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_QLT_NO)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.EST_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.INV_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.MDO_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PACK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PORT_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PRICE_DIST).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PROD_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.QTY_UOM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SDO_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOYG_NO)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.VSL_CODE)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.XDELV_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MKT_SDO_ASGN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.SDO_NO, e.VSL_TUG_CODE });

                entity.ToTable("MKT_SDO_ASGN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VSL_TUG_CODE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ASGN_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASGN_DATE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CAPT_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.QTY_DRY).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.QTY_UOM)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QTY_WET).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VSL_CARRIER_CODE)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MKT_SDO_ASGN_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MKT_SDO_ASGN_DEL");

                entity.Property(e => e.ASGN_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASGN_DATE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CAPT_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QTY_DRY).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.QTY_UOM)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QTY_WET).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VSL_CARRIER_CODE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VSL_TUG_CODE)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MKT_SDO_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MKT_SDO_DEL");

                entity.Property(e => e.ACD_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ACW_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.BAG_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BRAND_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CUST_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_CTRY)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_QLT_NO)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.EST_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.INV_NO)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.MDO_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PACK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PORT_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRICE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PRICE_DIST).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PROD_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.QTY_UOM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SDO_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOYG_NO)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.VSL_CODE)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.XDELV_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MKT_VSL_EXP>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.SDO_NO, e.EXP_TYPE })
                    .HasName("PK_MKT_VHC_EXP");

                entity.ToTable("MKT_VSL_EXP");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EXP_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOYG_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VSL_CODE)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MKT_VSL_EXP_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MKT_VSL_EXP_DEL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EXP_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOYG_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VSL_CODE)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MKT_VSL_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.VSL_CODE });

                entity.ToTable("MKT_VSL_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_CODE)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CAPT_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.OWNER_ADDR1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_ADDR2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_ADDR3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_CTRY)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OWNER_EMAIL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VSL_CAP).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.VSL_CTRY)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VSL_PORT)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_SUB_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_UOM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MKT_VSL_MST_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MKT_VSL_MST_DEL");

                entity.Property(e => e.CAPT_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_ADDR1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_ADDR2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_ADDR3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_CTRY)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OWNER_EMAIL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OWNER_PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VSL_CAP).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.VSL_CODE)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VSL_CTRY)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VSL_PORT)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_SUB_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_UOM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MKT_VSL_SCH>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.VSL_CODE, e.VOYG_NO, e.MDO_NO, e.SDO_NO });

                entity.ToTable("MKT_VSL_SCH");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_CODE)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.VOYG_NO)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MDO_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCPT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCPT_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCPT_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_ARVL_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_ARVL_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_ARVL_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_BERT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_BERT_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_BERT_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_DEPT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_DEPT_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_DEPT_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ARVL_CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ARVL_CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.BL_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COA_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COW_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COW_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DELV_ADD1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_CTRY)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPT_CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPT_CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DIST_MILE).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.DPORT_CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DPORT_CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DPORT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DPORT_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DPORT_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EST_ARVL_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EST_BERT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EST_DEPT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EST_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.FROM_PORT_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_FINISH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_FINISH_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_FINISH_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_START_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_START_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_START_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PORT_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY_UOM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOYG_NO_ACTL)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MKT_VSL_SCH_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MKT_VSL_SCH_DEL");

                entity.Property(e => e.ACCPT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCPT_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCPT_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_ARVL_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_ARVL_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_ARVL_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_BERT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_BERT_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_BERT_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_DEPT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_DEPT_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_DEPT_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACT_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ARVL_CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ARVL_CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.BL_NO)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.COA_NO)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.COW_NO)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.COW_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DELV_ADD1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_ADD3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DELV_CTRY)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.DEPT_CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPT_CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DIST_MILE).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.DPORT_CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DPORT_CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DPORT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DPORT_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DPORT_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EST_ARVL_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EST_BERT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EST_DEPT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EST_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.FROM_PORT_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_FINISH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_FINISH_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_FINISH_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_START_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_START_HH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LOAD_START_MM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MDO_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PORT_CODE)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY_UOM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SDO_NO)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOYG_NO)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.VOYG_NO_ACTL)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VSL_CODE)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OP_BALANCE>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.ACCT_NO });

                entity.ToTable("OP_BALANCE");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CREDIT).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DEBIT).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ERR_DESC)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OTH_DOC>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DOC_TYPE, e.FORM_NO })
                    .HasName("PK_OTH_DOC_1");

                entity.ToTable("OTH_DOC");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CATEGORY)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<OTH_DOC_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OTH_DOC_DEL");

                entity.Property(e => e.CATEGORY)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_BDGT_RVSD_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO });

                entity.ToTable("PRD_BDGT_RVSD_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.REVISED_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_BDGT_RVSD_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PRDCT_CODE, e.PROD_DATE, e.PROC_MONTH, e.FORM_NO });

                entity.ToTable("PRD_BDGT_RVSD_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BDGT_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.FIN_QTY)
                    .HasColumnType("decimal(14, 3)")
                    .HasComputedColumnSql("([BDGT_QTY]+[REVISED_QTY])", false);

                entity.Property(e => e.REVISED_QTY).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<PRD_BDGT_RVSD_TRN_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRD_BDGT_RVSD_TRN_DEL");

                entity.Property(e => e.BDGT_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.FIN_QTY)
                    .HasColumnType("decimal(14, 3)")
                    .HasComputedColumnSql("([BDGT_QTY]+[REVISED_QTY])", false);

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REVISED_QTY).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<PRD_BDGT_TYPE_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.BDGT_CODE });

                entity.ToTable("PRD_BDGT_TYPE_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BDGT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BDGT_DESC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_BDGT_TYPE_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.PROC_STG_CODE, e.BDGT_CODE });

                entity.ToTable("PRD_BDGT_TYPE_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_STG_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BDGT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_BDGT_YRLY_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO })
                    .HasName("PK_PRD_BDGT_YRLY_MST_NEW");

                entity.ToTable("PRD_BDGT_YRLY_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DAY_M1).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DAY_M10).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DAY_M11).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DAY_M12).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DAY_M2).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DAY_M3).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DAY_M4).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DAY_M5).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DAY_M6).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DAY_M7).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DAY_M8).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DAY_M9).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EMP_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY_M1).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY_M10).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY_M11).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY_M12).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY_M2).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY_M3).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY_M4).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY_M5).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY_M6).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY_M7).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY_M8).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY_M9).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_BDGT_YRLY_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO, e.PROD_DATE, e.PROC_MONTH })
                    .HasName("PK_PRD_BDGT_TRN_NEW");

                entity.ToTable("PRD_BDGT_YRLY_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACTUAL_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.BDGT_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.FIN_QTY)
                    .HasColumnType("decimal(14, 3)")
                    .HasComputedColumnSql("([BDGT_QTY]+[REVISED_QTY])", false);

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REVISED_QTY).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<PRD_BDGT_YRLY_TRN_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRD_BDGT_YRLY_TRN_DEL");

                entity.Property(e => e.ACTUAL_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.BDGT_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.FIN_QTY)
                    .HasColumnType("decimal(14, 3)")
                    .HasComputedColumnSql("([BDGT_QTY]+[REVISED_QTY])", false);

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REVISED_QTY).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<PRD_CCR>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.TRN_DATE });

                entity.ToTable("PRD_CCR");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.BL1_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BL2_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BL3_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BL4_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BL5_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BL6_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BPP_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CBT_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.CONCENTRATE9A)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CONCENTRATETN)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CONCENTRATETN2)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CRH_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FLOW9A)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FLOWTN)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FLOWTN2)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.G1_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G1_KWH).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G2_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G2_KWH).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G3_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G3_KWH).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G4_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G4_KWH).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.OTH_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PLANT1_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.PLANT2_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.PORT_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_CBT).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_PLANT_1).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_PLANT_2).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_PORT).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_T2).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_T3).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.PROC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.REMARKS)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.T2_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.T3_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.TAL_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_CCR_TMP>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.TRN_DATE });

                entity.ToTable("PRD_CCR_TMP");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.BL1_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BL2_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BL3_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BL4_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BL5_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BL6_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BPP_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CBT_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.CONCENTRATE9A)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CONCENTRATETN)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CONCENTRATETN2)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CRH_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FILE_NAME)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FLOW9A)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FLOWTN)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FLOWTN2)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.G1_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G1_KWH).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G2_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G2_KWH).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G3_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G3_KWH).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G4_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.G4_KWH).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.OTH_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PLANT1_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.PLANT2_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.PORT_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_CBT).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_PLANT_1).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_PLANT_2).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_PORT).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_T2).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.POWER_T3).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.PROC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.REMARKS)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.T2_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.T3_DIFF).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.TAL_KT)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_CRTFY_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO });

                entity.ToTable("PRD_CRTFY_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CRTFY_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_TYPE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.SPL_FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_CRTFY_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO, e.PROC_STG_CODE, e.PROD_DATE })
                    .HasName("PK_PRD_CRTFY_TRN_1");

                entity.ToTable("PRD_CRTFY_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_STG_CODE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PROD_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<PRD_MCHN_DATum>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.MCHN_TYPE, e.MCHN_PROC_STG, e.MCHN_PROC_SEQ, e.MCHN_SEQ_NO });

                entity.ToTable("PRD_MCHN_DATA");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MCHN_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MCHN_PROC_STG)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MCHN_PROC_SEQ)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MCHN_SEQ_NO)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CRTFY_FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.END_TIME).HasColumnType("datetime");

                entity.Property(e => e.MOISTURE).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.PWR_CONSUMPTION).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.START_TIME).HasColumnType("datetime");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.WEIGHT).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<PRD_MCHN_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.MCHN_CODE });

                entity.ToTable("PRD_MCHN_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MCHN_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.MCHN_BRAND)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MCHN_MODEL)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MCHN_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MCHN_SERIAL_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STD_KWH_CNSME).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.STD_MCH_CAPACITY).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_MINING_SITE>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.MS_CODE });

                entity.ToTable("PRD_MINING_SITE");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MS_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.MS_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_PRDCT_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.PRDCT_CODE })
                    .HasName("PK_PRD_PRDCT_TYPE_MST");

                entity.ToTable("PRD_PRDCT_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.PRDCT_DESC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_PRDCT_STG_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.PROC_STG_CODE, e.PRDCT_CODE });

                entity.ToTable("PRD_PRDCT_STG_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_STG_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_PROC_STG_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.PROC_SEQ, e.PROC_STG_CODE });

                entity.ToTable("PRD_PROC_STG_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROC_STG_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.PROC_STG_DESC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_PROD_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.MCHN_CODE, e.PROC_STG_CODE, e.PRDCT_CODE, e.PROD_DATE, e.PROD_TYPE, e.START_HOUR, e.END_HOUR });

                entity.ToTable("PRD_PROD_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MCHN_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PROC_STG_CODE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_TYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CRTFY_FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MR).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_PROD_TRN_ACTUAL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PRDCT_CODE, e.PROD_DATE, e.PROC_MONTH });

                entity.ToTable("PRD_PROD_TRN_ACTUAL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACTUAL_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.CCR_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DIFFERENCE)
                    .HasColumnType("decimal(14, 3)")
                    .HasComputedColumnSql("([ACTUAL_QTY]-[CCR_QTY])", false);

                entity.Property(e => e.MOIST).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_PROD_TRN_ACTUAL_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRD_PROD_TRN_ACTUAL_DEL");

                entity.Property(e => e.ACTUAL_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.CCR_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DIFFERENCE)
                    .HasColumnType("decimal(14, 3)")
                    .HasComputedColumnSql("([ACTUAL_QTY]-[CCR_QTY])", false);

                entity.Property(e => e.MOIST).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_PWR_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.MCHN_CODE, e.PROC_STG_CODE, e.PROD_DATE, e.PRDCT_CODE });

                entity.ToTable("PRD_PWR_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MCHN_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PROC_STG_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CRTFY_FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MR).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_SMPL_QLTY_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO, e.UNTT, e.PLAN_CODE, e.SMPL_DATE, e.PRDCT_CODE })
                    .HasName("PK_PRD_SMPL_QLTY");

                entity.ToTable("PRD_SMPL_QLTY_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SMPL_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EMP_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_SMPL_QLTY_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO, e.SMPL_TYPE });

                entity.ToTable("PRD_SMPL_QLTY_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SMPL_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VALUE).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<PRD_SMPL_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.SMPL_TYPE });

                entity.ToTable("PRD_SMPL_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SMPL_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SMPL_DESC)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PRD_SMPL_SPEC>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.PRDCT_CODE, e.SMPL_TYPE });

                entity.ToTable("PRD_SMPL_SPEC");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SMPL_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.MAX).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.MIN).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.STD).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_STOCK_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.WH_CODE, e.PRDCT_CODE });

                entity.ToTable("PRD_STOCK_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DRY_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.WET_QTY).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<PRD_STOCK_TRN>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRD_STOCK_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DRY_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.MOIST).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REASON)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.RELATED_FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SMPL_FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TYPE)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.WET_QTY).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PRD_STOCK_YARD>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PRDCT_CODE, e.PROC_MONTH });

                entity.ToTable("PRD_STOCK_YARD");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.EAST_BELOW).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.EAST_LOAD).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.PROD_DATE_INPUT)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.WEST_BELOW).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.WEST_LOAD).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<PRD_STOCK_YARD_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRD_STOCK_YARD_DEL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.EAST_BELOW).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.EAST_LOAD).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PRDCT_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_DATE_INPUT)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.WEST_BELOW).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.WEST_LOAD).HasColumnType("decimal(13, 3)");
            });

            modelBuilder.Entity<PRD_VHC_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.VHC_NO });

                entity.ToTable("PRD_VHC_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VHC_NO)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TRNP_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VHC_CAP).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.VHC_EMPTY_WGHT).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.VHC_KIND)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VHC_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VHC_SUB_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VHC_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VHC_YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PRD_WEIGHBRIDGE>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.TRN_DATE, e.PROC_MONTH, e.ID_TIMBANG });

                entity.ToTable("PRD_WEIGHBRIDGE");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.FLAG_TIMBANG)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JAM_KELUAR)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JAM_MASUK)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KETERANGAN)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NAMA_BARANG)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NAMA_SUPIR)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NAMA_SUPPLIER)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NO_POLISI)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NO_PO_DO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NO_TIKET)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OPERATOR_1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OPERATOR_2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REMARKS)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TANGGAL_KELUAR).HasColumnType("datetime");

                entity.Property(e => e.TANGGAL_MASUK).HasColumnType("datetime");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRD_WGHNG_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PROD_NO })
                    .HasName("PK_PRD_WGHNG_TRN_1");

                entity.ToTable("PRD_WGHNG_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROD_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DPCH_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DRIVER_ID)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DRIVER_NAME)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GROSS_WEIGHT).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.MCHN_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MINING_SITE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NET_WEIGHT).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRDCT_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VHC_KIND)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VHC_NO)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VHC_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PRE_PROJ_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PROJ_NO });

                entity.ToTable("PRE_PROJ_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCU_PROJ_COST).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ACCU_PROJ_COST_ADJ).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ACTIVE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BUDG_REF_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.C_ACTIVE_CODE)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when [Active_Code]='0' then 'NOT ACTIVE' when [Active_Code]='1' then 'ACTIVE' when [Active_Code]='8' then 'FINISHED' when [Active_Code]='9' then 'CAPITALIZED' else 'UNKNOWN' end)", true);

                entity.Property(e => e.C_START_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(CONVERT([char](6),[Start_Date],(112)))", true)
                    .IsFixedLength();

                entity.Property(e => e.C_SUB_PROJ_COST)
                    .HasColumnType("decimal(16, 2)")
                    .HasComputedColumnSql("([dbo].[Get_SubProjCost_For_PRE_PROJ_MST]('1',[Coy_Code],[Proj_No]))", false);

                entity.Property(e => e.C_SUB_PROJ_COST_ADJ)
                    .HasColumnType("decimal(16, 2)")
                    .HasComputedColumnSql("([dbo].[Get_SubProjCost_For_PRE_PROJ_MST]('2',[Coy_Code],[Proj_No]))", false);

                entity.Property(e => e.FIELD1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FIELD2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FINISH_DATE).HasColumnType("date");

                entity.Property(e => e.MAIN_PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROJ_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PROJ_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.START_DATE).HasColumnType("date");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRE_PROJ_MST_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRE_PROJ_MST_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCU_PROJ_COST).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ACCU_PROJ_COST_ADJ).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ACTIVE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BUDG_REF_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.C_START_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(CONVERT([char](6),[Start_Date],(112)))", true)
                    .IsFixedLength();

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.FIELD1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FIELD2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FINISH_DATE).HasColumnType("date");

                entity.Property(e => e.MAIN_PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROJ_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PROJ_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.START_DATE).HasColumnType("date");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PRE_PROJ_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PROJ_NO, e.TRN_SEQ });

                entity.ToTable("PRE_PROJ_TRN");

                entity.HasIndex(e => new { e.ACCT_NO, e.TRN_CTGR, e.COY_CODE, e.PROJ_NO }, "IX_PRE_PROJ_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.C_TRN_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(CONVERT([char](6),[Trn_Date],(112)))", true)
                    .IsFixedLength();

                entity.Property(e => e.C_TRN_TYPE)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when [TRN_TYPE]='NOR' then 'NORMAL' when [TRN_TYPE]='ADJ' then 'ADJUSTMENT' when [TRN_TYPE]='TRF' AND [TRN_AMT]>(0) then 'TRANSFER IN' when [TRN_TYPE]='TRF' AND [TRN_AMT]<(0) then 'TRANSFER OUT' when [TRN_TYPE]='CAP' then 'CAPITALIZE' else 'UNKNOWN' end)", true);

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CTGR)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_DATE).HasColumnType("date");

                entity.Property(e => e.TRN_DESC)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PRE_PROJ_TRN_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRE_PROJ_TRN_DEL");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.C_TRN_MONTH)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.C_TRN_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.PROJ_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CTGR)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_DATE).HasColumnType("date");

                entity.Property(e => e.TRN_DESC)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VOUCH_ITEM)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PRF_ATT_DET>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO, e.SEQ_NO })
                    .HasName("PK_PRF_DET");

                entity.ToTable("PRF_ATT_DET");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ATTCH_DESC)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ATTCH_TYPE)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PRF_MST_INFO>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO })
                    .HasName("PK_PRF_MST");

                entity.ToTable("PRF_MST_INFO");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BANK_ACCT_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_ACCT_NO)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.C_TOT_PAY_AMT)
                    .HasColumnType("decimal(17, 2)")
                    .HasComputedColumnSql("(([PAY_AMT]+[PPN_AMT])-[PPH_AMT])", false);

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FLAG_PPH_ON_PRF_CERTIFY).HasDefaultValueSql("((0))");

                entity.Property(e => e.INVOICE_NO)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PAID_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PAY_FOREIGN).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PAY_TO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAY_TRN_CODE)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPH_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPH_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPH_FOREIGN).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_BANK_ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PPN_FOREIGN).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_RATE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PURPOSE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SETTLE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("(0 = 'Outstanding', 1 = 'Settled', 2 = 'Paid')");

                entity.Property(e => e.SETTLE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.VCH_RECURR)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PRF_PAY_ADJ_TRN>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO, e.TRN_SEQ });

                entity.ToTable("PRF_PAY_ADJ_TRN");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.REV_VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.REV_VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_BASIC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_BASIC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_BASIC_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_PPH_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_PPN_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PRF_PAY_ADJ_TRN_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRF_PAY_ADJ_TRN_DEL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PNL_DEL_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REV_VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.REV_VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_BASIC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_BASIC_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_BASIC_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_PPH_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_CURR_PPN_RATE).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_PPH_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_PPN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VOUCH_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PRF_TRN_DET>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO, e.SEQ_NO })
                    .HasName("PK_PRF_TRN");

                entity.ToTable("PRF_TRN_DET");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CURR)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IDR_TRN_AMT)
                    .HasColumnType("decimal(31, 4)")
                    .HasComputedColumnSql("([TRN_AMT]*[CURR_RATE])", false);

                entity.Property(e => e.PPH_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TRN_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TRN_DTL)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PUR_PO_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PO_NO, e.PO_ITEM, e.PR_NO });

                entity.ToTable("PUR_PO_DTL");

                entity.HasIndex(e => new { e.COY_CODE, e.ITEM_NO }, "IX_PUR_PO_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.AMT_IDR).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DETAIL_DESC)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UNIT_PRICE).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PUR_PO_HIST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PO_NO, e.SEQ_NO });

                entity.ToTable("PUR_PO_HIST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CLOSE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CLOSE_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.REASON)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.REQUEST_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PUR_PO_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PO_NO });

                entity.ToTable("PUR_PO_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDGET_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CLOSE_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CLOSE_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength()
                    .HasComment("To indicate whether this particular PO has been closed or not (0 for not closed, 1 for closed)");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GEN_DESC)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PO_AMT_IDR)
                    .HasColumnType("decimal(31, 5)")
                    .HasComputedColumnSql("(round([PO_AMT]*[CURR_RATE],(2)))", false);

                entity.Property(e => e.PO_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PPN_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.REQUIRED_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SHIP_TO)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TOT_PO_AMT)
                    .HasColumnType("decimal(16, 2)")
                    .HasComputedColumnSql("([PO_AMT]+[PPN_AMT])", false);

                entity.Property(e => e.TOT_PO_AMT_IDR)
                    .HasColumnType("decimal(32, 5)")
                    .HasComputedColumnSql("(round(([PO_AMT]+[PPN_AMT])*[CURR_RATE],(2)))", false);

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<PUR_PR>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PR_NO })
                    .HasName("PK_PUR_PR_2");

                entity.ToTable("PUR_PR");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_NO)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_DATE).HasColumnType("datetime");

                entity.Property(e => e.STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PUR_PR_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PR_NO, e.PR_ITEM });

                entity.ToTable("PUR_PR_DTL");

                entity.HasIndex(e => new { e.COY_CODE, e.ITEM_NO }, "IX_PUR_PR_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DETAIL_DESC)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PO_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PO_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PURCHASER_EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PURCHASE_AT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("1 for HO, 2 for Site");

                entity.Property(e => e.REASON_NOT_YET_ORDERED)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.REQ_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.REQ_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UNIT_PRICE).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PUR_PR_HIST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PR_NO, e.SEQ_NO });

                entity.ToTable("PUR_PR_HIST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CLOSE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CLOSE_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.REASON)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.REQUEST_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PUR_PR_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PR_NO });

                entity.ToTable("PUR_PR_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ASSET)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BUDGET_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CLOSE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CLOSE_DATE)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CLOSE_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength()
                    .HasComment("To indicate whether this particular PR has been closed or not (0 for not closed, 1 for closed)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EXPECTED_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GEN_DESC)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IS_BUDGETED)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PRIORITY)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("N for Normal, H for High");

                entity.Property(e => e.PR_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PURCHASE_AT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("1 for HO, 2 for Site");

                entity.Property(e => e.PURPOSE)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.RELATED_INV_ITEMS_FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SAMPLE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("TO TELL PURCHASER THAT REQUESTOR HAS SAMPLE OR NOT");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TOT_REQ_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TOT_REQ_QTY).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USED_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USED_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USED_UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYN_LOG>(entity =>
            {
                entity.HasKey(e => new { e.SERVER, e.TO_SERVER, e.TRN_TYPE, e.TRN_TABLE, e.TRN_KEY, e.TRN_CONDITION, e.TRN_DATETIME });

                entity.ToTable("SYN_LOG");

                entity.Property(e => e.SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TO_SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('UPD')");

                entity.Property(e => e.TRN_TABLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_KEY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_CONDITION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_DATETIME)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.FINISH_DATETIME)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYN_LOG_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYN_LOG_DEL");

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.FINISH_DATETIME)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TO_SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_CONDITION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_DATETIME)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_KEY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TABLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYN_LOG_RECV>(entity =>
            {
                entity.HasKey(e => new { e.SERVER, e.FROM_SERVER, e.TRN_TYPE, e.TRN_TABLE, e.TRN_KEY, e.TRN_CONDITION, e.TRN_DATETIME });

                entity.ToTable("SYN_LOG_RECV");

                entity.Property(e => e.SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FROM_SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TABLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_KEY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_CONDITION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_DATETIME)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.FINISH_DATETIME)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYN_RECV>(entity =>
            {
                entity.HasKey(e => new { e.SERVER, e.FROM_SERVER, e.TRN_TABLE, e.TRN_KEY, e.TRN_CONDITION });

                entity.ToTable("SYN_RECV");

                entity.Property(e => e.SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FROM_SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TABLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_KEY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_CONDITION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYN_RECV_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYN_RECV_DEL");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FROM_SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_CONDITION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_KEY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TABLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYN_SEND>(entity =>
            {
                entity.HasKey(e => new { e.SERVER, e.TO_SERVER, e.TRN_TABLE, e.TRN_KEY, e.TRN_CONDITION });

                entity.ToTable("SYN_SEND");

                entity.Property(e => e.SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TO_SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TABLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_KEY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_CONDITION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYN_SEND_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYN_SEND_DEL");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TO_SERVER)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_CONDITION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_KEY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TABLE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYN_USER>(entity =>
            {
                entity.HasKey(e => e.USER_ID);

                entity.ToTable("SYN_USER");

                entity.Property(e => e.USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.PWD)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USER_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYN_USER_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYN_USER_DEL");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PWD)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USER_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYS_APPL_AUTH_TRN>(entity =>
            {
                entity.HasKey(e => new { e.USER_ID, e.COY_CODE, e.PGM_ID });

                entity.ToTable("SYS_APPL_AUTH_TRN");

                entity.Property(e => e.USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_APPL_DISP_SEQ>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .IsClustered(false);

                entity.ToTable("SYS_APPL_DISP_SEQ");

                entity.HasIndex(e => new { e.APP_SM_1, e.APP_SM_2 }, "IX_SYS_APPL_DISP_SEQ")
                    .IsUnique();

                entity.HasIndex(e => e.APP_SEQ, "IX_SYS_APPL_DISP_SEQ_1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.APP_SM_1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.APP_SM_2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYS_APPL_FAV>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .IsClustered(false);

                entity.ToTable("SYS_APPL_FAV");

                entity.HasIndex(e => new { e.USER_ID, e.COY_CODE, e.PGM_ID }, "IX_SYS_APPL_FAV")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_APPL_MST>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .IsClustered(false);

                entity.ToTable("SYS_APPL_MST");

                entity.HasIndex(e => new { e.COY_CODE, e.APP_SM_1, e.APP_SM_2, e.PGM_SEQ, e.PGM_ID }, "IX_SYS_APPL_MST")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.APP_SM_1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Main Module e.g.: Finance, Sales etc");

                entity.Property(e => e.APP_SM_2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Sub Module e.g.: A/P, G/L etc");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PARAM)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PGM_DESC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_APPL_START>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .IsClustered(false);

                entity.ToTable("SYS_APPL_START");

                entity.HasIndex(e => new { e.USER_ID, e.COY_CODE, e.PGM_ID }, "IX_SYS_APPL_START")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PGM_ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_APPRV_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.APPRV_DOC_TYPE, e.APPRV_EMP_ID })
                    .HasName("PK_SYS_APPRV_MST2");

                entity.ToTable("SYS_APPRV_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.APPRV_EMP_ID)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPECIAL_LVL)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SYS_APPRV_MST_REF>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.APPRV_DOC_TYPE, e.APPRV_EMP_ID, e.APPRV_LVL, e.APPRV_LVL_SEQ })
                    .HasName("PK_OK_SYS_APPRV");

                entity.ToTable("SYS_APPRV_MST_REF");

                entity.HasIndex(e => new { e.COY_CODE, e.APPRV_DOC_TYPE, e.APPRV_LVL, e.APPRV_TYPE }, "IX_SYS_APPRV_MST_REF");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.APPRV_EMP_ID)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.APPRV_ID)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.APPRV_LVL_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.APPRV_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COND)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EDITABLE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORWARD)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LVL_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.POSITION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QUERY)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYS_CAL_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.CAL_DATE });

                entity.ToTable("SYS_CAL_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CAL_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DAY_NAME)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HOLY_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMK)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYS_CLOSING_ADM>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.MODULE, e.UNTT, e.CLOSE_MONTH, e.CLOSE_SEQ });

                entity.ToTable("SYS_CLOSING_ADM");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MODULE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CLOSE_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CLOSE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.REMARK)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_COY_AUTH_TRN>(entity =>
            {
                entity.HasKey(e => new { e.USER_ID, e.COY_CODE });

                entity.ToTable("SYS_COY_AUTH_TRN");

                entity.Property(e => e.USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WORK_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_COY_MST>(entity =>
            {
                entity.HasKey(e => e.COY_CODE);

                entity.ToTable("SYS_COY_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCOUNTING_START_MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADDR_1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ADDR_2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ADDR_3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ALLOW_MULTIPLE_EMP_ADV_FOR_ONE_EMP)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.CITY)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.COY_GROUP)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.COY_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_WEBSITE)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FAX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FIN_COST_CTR_IN_CIP)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FIN_PL_START_ACCT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FIN_VCH_VERIFY)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength()
                    .HasComment("flag to indicate whether this particular company needs to have \"voucher verification\" feature in finance accounting module or not (0 means no need, 1 means need)");

                entity.Property(e => e.FXA_CIP_PREOPS)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GAR_ISO_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GRR_ISO_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NPWP)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NPWP_ADDR)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PKP_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PKP_NO)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PO_ISO_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PR_ISO_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PURCHASING_MANAGER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SEND_EMAIL_FOR_GAR_TO_PURCHASER)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SEND_EMAIL_FOR_PO_TO_SUPPLIER)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.SEND_EMAIL_FOR_WF_DOC_TO_APPROVER)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SEND_EMAIL_FOR_WF_DOC_TO_CREATOR)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SHOW_LINK_PRINT_PO_FOR_INTERNAL)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength();

                entity.Property(e => e.SHOW_PPN_IN_PO_SUPPLIER)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SHOW_SHIP_COST_ADV_PRF)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_CTRY_MST>(entity =>
            {
                entity.HasKey(e => e.CTRY_CODE);

                entity.ToTable("SYS_CTRY_MST");

                entity.Property(e => e.CTRY_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CTRY_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYS_CURR_MST>(entity =>
            {
                entity.HasKey(e => e.CURR_CODE);

                entity.ToTable("SYS_CURR_MST");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_NAME)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DISP_ORDER)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.INPUT_RATE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_CURR_RATE>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.CURR_DATE, e.CURR_CODE });

                entity.ToTable("SYS_CURR_RATE");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(16, 3)");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYS_DISCUSS>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DISCUSS_ID });

                entity.ToTable("SYS_DISCUSS");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DISCUSS_ID)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CLOSE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CLOSE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DISCUSS_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DISCUSS_DESC)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NOTIFY_ID).IsUnicode(false);

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYS_DISCUSS_MSG>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DISCUSS_ID, e.MSG_ID });

                entity.ToTable("SYS_DISCUSS_MSG");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DISCUSS_ID)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MSG).IsUnicode(false);

                entity.Property(e => e.REPLY_MSG_DATE).HasColumnType("datetime");

                entity.Property(e => e.REPLY_MSG_ID).IsUnicode(false);

                entity.Property(e => e.SPECIAL_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STAT_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYS_DISCUSS_READ>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DISCUSS_ID, e.READ_ID });

                entity.ToTable("SYS_DISCUSS_READ");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DISCUSS_ID)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.READ_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYS_DOC_APPRV>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DOC_TYPE, e.DOC_NO })
                    .HasName("PK_APPRV");

                entity.ToTable("SYS_DOC_APPRV");

                entity.HasIndex(e => new { e.COY_CODE, e.DOC_NO, e.DOC_TYPE }, "IX_SYS_DOC_APPRV");

                entity.HasIndex(e => new { e.DOC_STATUS, e.CURR_APPRV, e.COY_CODE }, "IX_SYS_DOC_APPRV_1");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_APPRV)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LAST_APPRV_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LAST_APPRV_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OWN_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PERSON_LVL)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PROG_ID)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.READER_ID)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.READER_ROLE)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.REJC_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REJC_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYS_DOC_APPRV_DET>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DOC_TYPE, e.DOC_NO, e.SEQ_NO })
                    .HasName("PK_APPROVAL_DOC_DET2_1");

                entity.ToTable("SYS_DOC_APPRV_DET");

                entity.HasIndex(e => new { e.COY_CODE, e.DOC_NO, e.SEQ_NO }, "IX_SYS_DOC_APPRV_DET_1");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SEQ_NO).ValueGeneratedOnAdd();

                entity.Property(e => e.APPRV_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APPRV_TASK)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LVL_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PERSON_LVL)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ROLE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SURR_FROM)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_DOC_ATTCH>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DOC_TYPE, e.DOC_NO, e.ATTCH_NAME, e.ATTCH_EXT })
                    .HasName("pk_sys_doc_attch");

                entity.ToTable("SYS_DOC_ATTCH");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ATTCH_NAME)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ATTCH_EXT)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ATTCH_CONTENT_TYPE)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ATTCH_SIZE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.FLAG)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYS_DOC_ATTCH_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_DOC_ATTCH_DEL");

                entity.Property(e => e.ATTCH_CONTENT_TYPE)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ATTCH_EXT)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ATTCH_NAME)
                    .HasMaxLength(125)
                    .IsUnicode(false);

                entity.Property(e => e.ATTCH_SIZE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYS_DOC_PRINT>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DOC_TYPE, e.DOC_NO });

                entity.ToTable("SYS_DOC_PRINT");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LAST_PRINT_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LAST_PRINT_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_EMP_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.EMP_NO });

                entity.ToTable("SYS_EMP_MST");

                entity.HasIndex(e => e.EMP_NO, "IX_SYS_EMP_MST")
                    .IsUnique();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BANK_AC_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_AC_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONTRACT_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ECHELON)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMP_NAME)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FLG_LEAVE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GENDER)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GRADE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HR_EMP_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JOB_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MOBILE_PHONE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RESIGN_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SERV_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SERV_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WORK_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_ERP_MSG>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .IsClustered(false);

                entity.ToTable("SYS_ERP_MSG");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.END_BLOCK_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.END_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.LONG_DESC)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MSG_TYPE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SHORT_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.START_BLOCK_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.START_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYS_ERP_REF>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .IsClustered(false);

                entity.ToTable("SYS_ERP_REF");

                entity.HasIndex(e => new { e.COY_CODE, e.REC_TYPE, e.REC_CODE, e.UNTT }, "IX_SYS_ERP_REF")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GROUP_CODE)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GROUP_NAME)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GROUP_TYPE)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LONG_DESC)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.REC_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHORT_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UNTT)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYS_NUMBERING>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.APP_CODE, e.KEY_CODE, e.SEQ_NO });

                entity.ToTable("SYS_NUMBERING");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.APP_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KEY_CODE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LAST_USED).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYS_ORG_STR>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.UNTT, e.PLAN_CODE, e.DEPT_CODE });

                entity.ToTable("SYS_ORG_STR");

                entity.HasIndex(e => new { e.COY_CODE, e.EMP_NO }, "IX_SYS_ORG_STR");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BLOCK_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LVL_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ORG_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHORT_DESC)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYS_OTHER_REF>(entity =>
            {
                entity.ToTable("SYS_OTHER_REF");

                entity.Property(e => e.ACCT_NO_1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACCT_NO_2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ALLOW_MANUAL_ENTRY)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.BLOCK_STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_KIND)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REC_TITLE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.REC_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_PAYEE_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.PAYEE_NO, e.PAYEE_TYPE });

                entity.ToTable("SYS_PAYEE_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACTIVE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BANK_AC_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_AC_NO)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BELONG_TO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_CODE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CONT_PERS_NM1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONT_PERS_NM2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONT_PERS_NM3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CTRY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEST_CODE)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IS_VENDOR_PROJECT).HasDefaultValueSql("('')");

                entity.Property(e => e.MOBILE_NO1)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MOBILE_NO2)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MOBILE_NO3)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NPWP_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_ADDR1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_ADDR2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_ADDR3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_FAX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NAME)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_PHONE1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_PHONE2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TELEX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PKP_NO)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SFA_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.ZIP_CODE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_PAYEE_MST_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_PAYEE_MST_DEL");

                entity.Property(e => e.ACTIVE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BANK_AC_NAME)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_AC_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BELONG_TO)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CITY_CODE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CONT_PERS_NM1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONT_PERS_NM2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONT_PERS_NM3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CTRY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEST_CODE)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMAIL3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MOBILE_NO1)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MOBILE_NO2)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MOBILE_NO3)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NPWP_NO)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_ADDR1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_ADDR2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_ADDR3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_FAX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NAME)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_PHONE1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_PHONE2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TELEX)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PAYEE_TYPE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PKP_NO)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.REACTIVATE_CODE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SFA_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");

                entity.Property(e => e.ZIP_CODE)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SYS_ROLE_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DOC_TYPE, e.ROLE });

                entity.ToTable("SYS_ROLE_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ROLE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYS_ROLE_SETUP>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DOC_TYPE, e.ROLE, e.USER_ID })
                    .HasName("PK_SYS_ROLE_SETUP_1");

                entity.ToTable("SYS_ROLE_SETUP");

                entity.HasIndex(e => new { e.ROLE, e.USER_ID, e.COY_CODE, e.DOC_TYPE }, "IX_SYS_ROLE_SETUP");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ROLE)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.QUERY)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WH_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SYS_USER_MST>(entity =>
            {
                entity.HasKey(e => e.USER_ID);

                entity.ToTable("SYS_USER_MST");

                entity.Property(e => e.USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EFF_DATE).HasColumnType("date");

                entity.Property(e => e.LAST_ACCESS).HasColumnType("datetime");

                entity.Property(e => e.LAST_UPD_PWD)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PWD)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USER_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SYS_USER_SURR>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.DOC_TYPE, e.FROM_USER_ID, e.START_DATE });

                entity.ToTable("SYS_USER_SURR");

                entity.HasIndex(e => new { e.TO_USER_ID, e.COY_CODE, e.DOC_TYPE }, "IX_SYS_USER_SURR");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FROM_USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.START_DATE).HasColumnType("smalldatetime");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.END_DATE).HasColumnType("smalldatetime");

                entity.Property(e => e.REASON)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TO_USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<SYS_USER_SURR_DEL>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYS_USER_SURR_DEL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEL_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEL_DATE).HasColumnType("datetime");

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.END_DATE).HasColumnType("smalldatetime");

                entity.Property(e => e.FROM_USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REASON)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.START_DATE).HasColumnType("smalldatetime");

                entity.Property(e => e.TO_USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<TEMP_POWER>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.TRN_DATE, e.TRN_TYPE });

                entity.ToTable("TEMP_POWER");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.KWH)
                    .HasColumnType("decimal(20, 3)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TEMP_PRD_CCR>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.TRN_PROD })
                    .HasName("PK_TEMP_PRD_CCR_1");

                entity.ToTable("TEMP_PRD_CCR");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_PROD)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.BPP_PROD)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CRH_PROD)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MOIS)
                    .HasColumnType("decimal(11, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<TEMP_SHIPMENT>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.TRN_DATE, e.PROC_MONTH, e.TRN_TYPE });

                entity.ToTable("TEMP_SHIPMENT");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.WMT)
                    .HasColumnType("decimal(20, 3)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TEMP_SHIPMENT_NEW>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.TRN_DATE, e.PROC_MONTH });

                entity.ToTable("TEMP_SHIPMENT_NEW");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TRN_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PROC_MONTH)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ACTUAL_QTY).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.BDGT_QTY).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.REVISED_QTY).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<TEMP_STOCK>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.STOCK_DATE, e.PROD_TYPE });

                entity.ToTable("TEMP_STOCK");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.STOCK_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.PROD_TYPE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ACT_KT).HasColumnType("decimal(20, 3)");

                entity.Property(e => e.BLW_KT)
                    .HasColumnType("decimal(20, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TRN_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UploadCOA>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UploadCOA");

                entity.Property(e => e.COA).HasMaxLength(255);

                entity.Property(e => e.English).HasMaxLength(255);

                entity.Property(e => e.Nature).HasMaxLength(255);
            });

            modelBuilder.Entity<UploadCOA2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UploadCOA2");

                entity.Property(e => e.COA).HasMaxLength(255);

                entity.Property(e => e.English).HasMaxLength(255);

                entity.Property(e => e.Nature).HasMaxLength(255);
            });

            modelBuilder.Entity<View_EXP_GEN_LEDG>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_EXP_GEN_LEDG");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NET_AMT).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<View_FIN_COST_ELM_LEDG>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_FIN_COST_ELM_LEDG");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BAL_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_ELM)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NET_AMT).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<View_FIN_EXP_LEDG>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_FIN_EXP_LEDG");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BAL_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BUDG_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NET_AMT).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<View_FIN_EXP_LEDG_PLUS_VOUCHER_UNAPPROVED>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_FIN_EXP_LEDG_PLUS_VOUCHER_UNAPPROVED");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.BAL_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BUDG_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CR_AMT).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.DR_AMT).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NET_AMT).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<View_FIN_GEN_LEDG>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_FIN_GEN_LEDG");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BAL_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BAL_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.BUDG_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BUDG_QTY).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DR_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.MONTH)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NET_AMT).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.YEAR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<View_INV_STOCK>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_INV_STOCK");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.avail_qty).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.on_hand_qty).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.otw_qty).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.wh_code)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<View_Outstanding_PR>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Outstanding_PR");

                entity.Property(e => e.CLOSE_DATE).HasColumnType("datetime");

                entity.Property(e => e.CLOSE_STAT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMP_UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ITEM_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ITEM_NO)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_ITEM)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PR_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PURCHASER_EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PURCHASE_AT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REQ_AMT).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.REQ_QTY).HasColumnType("decimal(38, 3)");

                entity.Property(e => e.UOM)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.USED_DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USED_PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USED_UNTT)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.USER_ID)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<View_PRF_ADV_Voucher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_PRF_ADV_Voucher");

                entity.Property(e => e.coy_code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.form_no)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.vouch_No)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Z_CAD_ADV_DTL>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO, e.SEQ_NO })
                    .HasName("PK_CAD_ADV_DTL");

                entity.ToTable("Z_CAD_ADV_DTL");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADV_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.DETAILS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IDR_ADV_AMT).HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<Z_CAD_ADV_EXP>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO, e.SEQ_NO })
                    .HasName("PK_CAD_ADV_EXP");

                entity.ToTable("Z_CAD_ADV_EXP");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_RATE).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.DETAILS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EXP_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.IDR__EXP_AMT).HasColumnType("decimal(16, 2)");
            });

            modelBuilder.Entity<Z_CAD_ADV_MST>(entity =>
            {
                entity.HasKey(e => new { e.COY_CODE, e.FORM_NO })
                    .HasName("PK_CAD_ADV_MST");

                entity.ToTable("Z_CAD_ADV_MST");

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FORM_NO)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ADV_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ADV_VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BANK_ACCT_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_ACCT_NO)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BANK_NAME)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CONTACT_PERSON)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_DATE).HasColumnType("datetime");

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DUE_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMAIL_ADDR)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EXP_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.EXP_VOUCH_NO)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PAY_METHOD)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PHONE_EXT)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PLAN_CODE)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PURPOSE)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RETURN_AMT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UPD_DATE).HasColumnType("datetime");
            });

            modelBuilder.Entity<Z_CONV_COST>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_CONV_COST");

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DEPT_CODE)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NEW_COST)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Z_JS_ACCT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_JS_ACCT");

                entity.Property(e => e.ACCT_NO).HasMaxLength(255);

                entity.Property(e => e.ACCT_TITLE).HasMaxLength(255);
            });

            modelBuilder.Entity<Z_MAP_SJU>(entity =>
            {
                entity.ToTable("Z_MAP_SJU");

                entity.Property(e => e.COY_CODE).HasMaxLength(255);

                entity.Property(e => e.DEPT_CODE).HasMaxLength(255);

                entity.Property(e => e.EMP_NO).HasMaxLength(255);

                entity.Property(e => e.LVL_CODE).HasMaxLength(255);

                entity.Property(e => e.NEW_DEPT).HasMaxLength(255);

                entity.Property(e => e.NEW_DESC).HasMaxLength(255);

                entity.Property(e => e.ORG_DESC).HasMaxLength(255);

                entity.Property(e => e.PLAN_CODE).HasMaxLength(255);

                entity.Property(e => e.SHORT_DESC).HasMaxLength(255);

                entity.Property(e => e.UNTT).HasMaxLength(255);
            });

            modelBuilder.Entity<Z_Supplier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_Supplier");

                entity.Property(e => e.ADDRESS).HasMaxLength(255);

                entity.Property(e => e.CITY).HasMaxLength(255);

                entity.Property(e => e.CONTACT_PERSON_1)
                    .HasMaxLength(255)
                    .HasColumnName("CONTACT PERSON 1");

                entity.Property(e => e.CONTACT_PERSON_2)
                    .HasMaxLength(255)
                    .HasColumnName("CONTACT PERSON 2");

                entity.Property(e => e.CONTACT_PERSON_3)
                    .HasMaxLength(255)
                    .HasColumnName("CONTACT PERSON 3");

                entity.Property(e => e.COUNTRY).HasMaxLength(255);

                entity.Property(e => e.EMAIL_1)
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL 1");

                entity.Property(e => e.EMAIL_2)
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL 2");

                entity.Property(e => e.EMAIL_3)
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL 3");

                entity.Property(e => e.FAX).HasMaxLength(255);

                entity.Property(e => e.MOBILE_PHONE_1)
                    .HasMaxLength(255)
                    .HasColumnName("MOBILE PHONE 1");

                entity.Property(e => e.MOBILE_PHONE_2).HasColumnName("MOBILE PHONE 2");

                entity.Property(e => e.MOBILE_PHONE_3)
                    .HasMaxLength(255)
                    .HasColumnName("MOBILE PHONE 3");

                entity.Property(e => e.NAME).HasMaxLength(255);

                entity.Property(e => e.PHONE_1)
                    .HasMaxLength(255)
                    .HasColumnName("PHONE 1");

                entity.Property(e => e.PHONE_2)
                    .HasMaxLength(255)
                    .HasColumnName("PHONE 2");

                entity.Property(e => e.ZIP_CODE).HasColumnName("ZIP CODE");
            });

            modelBuilder.Entity<Z_VOUCHER_ENTRY>(entity =>
            {
                entity.ToTable("Z_VOUCHER_ENTRY");

                entity.Property(e => e.ACCT_NO)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.COST_CTR)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CREDIT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DEBIT).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.DESCRIPTION)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OLD_ACCT_NAME)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OLD_ACCT_NO)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TRN_CODE)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VCH_DATE)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VCH_NO)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VCH_TYPE)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vw_approval_doc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_approval_docs");

                entity.Property(e => e.APPRV_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CURR_APPRV)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CURR_APPRV_LVL_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CURR_USER_ID)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CURR_USER_ID_ORI)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EDITABLE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LAST_APPRV_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.LAST_APPRV_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OWN_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vw_approval_docs_all>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_approval_docs_all");

                entity.Property(e => e.APPRV_TYPE)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.COY_CODE)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CRE_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CURR_APPRV)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CURR_APPRV_LVL_DESC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CURR_USER_ID)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CURR_USER_ID_ORI)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_DATE)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DOC_STATUS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DOC_TYPE)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EDITABLE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LAST_APPRV_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LAST_APPRV_DATE)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OWN_BY)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.REMARK)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
