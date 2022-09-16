using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class PRD_WEIGHBRIDGE
    {
        public string COY_CODE { get; set; } = null!;
        public string TRN_DATE { get; set; } = null!;
        public string PROC_MONTH { get; set; } = null!;
        public long ID_TIMBANG { get; set; }
        public string? NO_TIKET { get; set; }
        public string? NO_POLISI { get; set; }
        public string? NO_PO_DO { get; set; }
        public string? NAMA_SUPPLIER { get; set; }
        public string? NAMA_BARANG { get; set; }
        public string? NAMA_SUPIR { get; set; }
        public long? GROSS { get; set; }
        public long? TARRE { get; set; }
        public long? NETTO { get; set; }
        public string? JAM_MASUK { get; set; }
        public string? JAM_KELUAR { get; set; }
        public DateTime? TANGGAL_MASUK { get; set; }
        public DateTime? TANGGAL_KELUAR { get; set; }
        public string? KETERANGAN { get; set; }
        public string? OPERATOR_1 { get; set; }
        public string? OPERATOR_2 { get; set; }
        public string? FLAG_TIMBANG { get; set; }
        public string? REMARKS { get; set; }
        public string? CRE_BY { get; set; }
        public DateTime? CRE_DATE { get; set; }
        public string? UPD_BY { get; set; }
        public DateTime? UPD_DATE { get; set; }
    }
}
