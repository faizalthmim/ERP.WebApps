using System;
using System.Collections.Generic;

namespace ERP.WebApps.Infrastructure.EntityModels
{
    public partial class FIN_QUERY
    {
        public string COY_CODE { get; set; } = null!;
        public string REC_CODE { get; set; } = null!;
        public string PAYEE_TYPE { get; set; } = null!;
        public string REC_TITLE { get; set; } = null!;
        public string TABLE_NAME { get; set; } = null!;
        public string? KEY_FIELD { get; set; }
        public string DATA_VALUE { get; set; } = null!;
        public string DATA_TEXT { get; set; } = null!;
        public string DATA_TITLE_TEXT { get; set; } = null!;
    }
}
