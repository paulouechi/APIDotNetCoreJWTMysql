using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using APIDotNetCoreJWTMysql.Requests;
using APIDotNetCoreJWTMysql.Service.Interface;

namespace APIDotNetCoreJWTMysql.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        protected readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("valid")]
        public ActionResult ValidateUser([FromBody]UserLogin request)
        {
            var ret = _userService.GetToken(request.UserName, request.Password);

            if (ret == null)
                return StatusCode(401);

            return Json(ret);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("create")]
        public JsonResult InsertUser(string username, string password, string confirmpassword)
        {
            if (password == confirmpassword)
            {
                _userService.InsertUser(username, password);
            }
            return Json("User Created Successfully! :)");
        }
    }
}