using ERP.WebApps.Core.ViewModel;
using ERP.WebApps.Core.ViewModel.Privacy;
using ERP.WebApps.Infrastructure.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.WebApps.Core.Interfaces
{
    public interface IUserService
    {
        public List<SYS_USER_MST> GetUser(DataTableModel model, out int totalRow);
        public SYS_USER_MST Insert(UserViewModel model);
        public SYS_USER_MST Update(UserViewModel model);
        public SYS_USER_MST FindByID(string id);
        public string DeleteByID(string id);
    }
}
