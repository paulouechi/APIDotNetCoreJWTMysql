using APIDotNetCoreJWTMysql.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIDotNetCoreJWTMysql.Controllers
{
    [Route("api/results")]
    public class ResultController : Controller
    {
        private readonly ILogger<ResultController> _logger;

        protected readonly IAccountService _accountService;

        public ResultController(ILogger<ResultController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route("list")]
        public JsonResult GetList()
        {
            var returnJson = _accountService.GetAccountList();

            return Json(returnJson);
        }

    }
}