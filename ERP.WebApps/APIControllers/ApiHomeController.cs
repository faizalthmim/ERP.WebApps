using ERP.WebApps.Core.Interfaces;
using ERP.WebApps.Core.ViewModel;
using ERP.WebApps.Core.ViewModel.Privacy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ERP.WebApps.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiHomeController : ControllerBase
    {
        private readonly IUserService _userService;
        public ApiHomeController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("ListGrid")]
        [HttpPost]
        public ActionResult ListGrid([FromBody] DataTableModel dtModel)
        {
            try
            {
                int totalRow = 0;
                var data = _userService.GetUser(dtModel, out totalRow).Select(m => new UserViewModel()
                {
                    USER_ID = m.USER_ID,
                    USER_NAME = m.USER_NAME,
                    PWD = m.PWD,
                }).ToList();
                var _result = new DataTableReturnModel<UserViewModel>()
                {
                    data = data,
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

        [Route("Create")]
        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] UserViewModel model)
        {
            var jsonResult = new JsonResultModel();

            try
            {
                _userService.Insert(model);
                jsonResult.InsertSucceed();

                return Ok(jsonResult);
            }
            catch (Exception ex)
            {
                jsonResult.SetValues(false, ex.GetBaseException().Message);
                return Ok(jsonResult);
            }
        }
        [Route("Edit")]
        [HttpPost]
        public async Task<ActionResult> Update([FromBody] UserViewModel model)
        {
            var jsonResult = new JsonResultModel();
            try
            {
                _userService.Update(model);
                jsonResult.InsertSucceed();

                return Ok(jsonResult);
            }
            catch (Exception ex)
            {
                jsonResult.SetValues(false, ex.GetBaseException().Message);
                return Ok(jsonResult);
            }
        }

        [Route("Delete")]
        [HttpPost]
        public async Task<ActionResult> Delete([FromBody] UserViewModel model)
        {
            var jsonResult = new JsonResultModel();
            try
            {

                var res = _userService.DeleteByID(model.USER_ID);
                if (res !=null)
                {
                    jsonResult.DeleteSucceed();
                }

                return Ok(jsonResult);
            }
            catch (Exception ex)
            {

                jsonResult.SetValues(false, ex.GetBaseException().Message);
                return Ok(jsonResult);
            }
        }

    }
}
