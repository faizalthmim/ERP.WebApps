using ERP.WebApps.Core.Interfaces;
using ERP.WebApps.Core.ViewModel;
using ERP.WebApps.Core.ViewModel.Authenticate;
using ERP.WebApps.Core.ViewModel.Privacy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERP.WebApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IUserService _userService;
        public NotificationController(IUserService userService)
        {
            _userService = userService;
        }


        [Authorize]
        [HttpPost]
        [Route("GetList")]
        public IActionResult Get()
        {
            try
            {
                int totalRow = 0;
                DataTableModel dtModel = new DataTableModel();
                dtModel.order = new List<Order>();
                dtModel.start = 0;
                dtModel.length = 9999;
                var data = _userService.GetUser(dtModel, out totalRow).Select(m => new UserViewModel()
                {
                    USER_ID = m.USER_ID,
                    USER_NAME = m.USER_NAME,
                    PWD = m.PWD,
                }).ToList();
                var _result = new DataTableReturnModel<NotificationViewModel>()
                {
                    data = data.Select(m => new NotificationViewModel() { 
                        ID = m.USER_ID,
                        Title = m.USER_NAME,
                        Description = m.PWD,
                        Category = m.USER_NAME

                    }).ToList(),
                    draw = dtModel.draw,
                    recordsTotal = totalRow,
                    recordsFiltered = totalRow,

                };
                return Ok(_result);

            }
            catch (Exception ex)
            {
                return Ok(new { error = ex.Message });
            }
        }

        [Authorize]
        [HttpPost]
        [Route("GetByID")]

        public IActionResult GetByID([FromBody] NotificationViewModel model)
        {
            var data = _userService.FindByID(model.ID);
            if(data != null)
            {
                return Ok(new NotificationViewModel()
                {
                    ID = data.USER_ID,
                    Title = data.USER_NAME,
                    Description = data.PWD
                });
            }
            return Ok(new
            {
                error = "data kosong"
            }); 
        }

    }
}
