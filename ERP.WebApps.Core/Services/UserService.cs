using ERP.WebApps.Core.Interfaces;
using ERP.WebApps.Core.ViewModel;
using ERP.WebApps.Core.ViewModel.Privacy;
using ERP.WebApps.Infrastructure.EntityModels;
using ERP.WebApps.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.WebApps.Core.Services
{
    public class UserService : IUserService
    {
        private UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<SYS_USER_MST> GetUser(DataTableModel model, out int totalRow)
        {
            var whereClause = String.Empty;
            var orderBy = String.Empty;
            if(model.order.Count > 0)
            {
                var modelOrder = model.order.FirstOrDefault();
                if(modelOrder != null)
                {
                    var columnName = model.columns[modelOrder.column].data;
                    orderBy = (columnName != null) ? String.Format("{0} {1}", columnName, modelOrder.dir) : orderBy;
                }
            }
            return _userRepository.GetUser(whereClause, orderBy, model.start, model.length, out totalRow);
        }

        public SYS_USER_MST Insert(UserViewModel model)
        {

            var user = new SYS_USER_MST();
            user.USER_ID = model.USER_ID;
            user.USER_NAME = model.USER_NAME;
            user.PWD = model.PWD;

            return _userRepository.Insert(user);
        }

        public SYS_USER_MST Update(UserViewModel model)
        {
            var user = new SYS_USER_MST();
            user.USER_ID = model.USER_ID;
            user.USER_NAME = model.USER_NAME;
            user.PWD = model.PWD;

            return _userRepository.Insert(user);
        }
        public SYS_USER_MST FindByID(string id)
        {
            return _userRepository.FindByID(id);
        }
        public string? DeleteByID(string id)
        {
            var user = _userRepository.FindByID(id);
            if(user != null)
            {
                return _userRepository.Delete(user);
            }
            return null;
        }

    }
}
