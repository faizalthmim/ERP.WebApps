using ERP.WebApps.Infrastructure.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ERP.WebApps.Infrastructure.Base
{
    public abstract class BaseRepository : IDisposable
    {
        protected readonly ERP_PROD_JSContext context;
        protected BaseRepository(ERP_PROD_JSContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {

            if (context == null)
                return;

            context.Dispose();
        }
    }
}
