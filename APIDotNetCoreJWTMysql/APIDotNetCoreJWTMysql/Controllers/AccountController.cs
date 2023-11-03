using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using APIDotNetCoreJWTMysql.Model;
using APIDotNetCoreJWTMysql.Service.Interface;
using APIDotNetCoreJWTMysql.Services;

namespace APIDotNetCoreJWTMysql.Controllers
{
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        protected readonly IAccountService _accountService;

        public AccountController(ILogger<AccountController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("insert")]
        public JsonResult insertAccount([FromBody]Account request) {
            var returnJson = "Account Insert { UserLogin = '" + request.UserLogin + "', dateRegister = '" + request.dateRegister + "' , inputType = '" + request.inputType + "', inputValue " + request.inputValue + " }";
            _accountService.InsertAccount(request.UserLogin, request.dateRegister, request.inputType, request.inputValue);
            _logger.LogInformation(returnJson);
            return Json(returnJson);
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("update")]
        public JsonResult updateAccount([FromBody] Account request)
        {
            var returnJson = "Account Update { Id = " + request.id + " , UserLogin = '" + request.UserLogin + "', dateRegister = '" + request.dateRegister + "' , inputType = '" + request.inputType + "', inputValue " + request.inputValue + " }";
            _accountService.UpdateAccount(request.id ,request.UserLogin, request.dateRegister, request.inputType, request.inputValue);
            _logger.LogInformation(returnJson);
            return Json(returnJson);
        }

        [AllowAnonymous]
        [HttpDelete]
        [Route("delete")]
        public void deleteAccount([FromQuery] int id)
        {
            _accountService.deleteAccount(id);
            _logger.LogInformation("Delete Account Id = " + id);

        }

        [AllowAnonymous]
        [HttpGet]
        [Route("find")]
        public JsonResult findAccount([FromQuery]int id)
        {
            var objAccount = _accountService.GetAccount(id);
            _logger.LogInformation("Delete Account Id = " + id);
            return Json(objAccount);
        }

    }
}
