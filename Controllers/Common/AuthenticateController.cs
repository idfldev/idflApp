using idflApp.auth;
using idflApp.Constants;
using idflApp.Core.Dtos;
using idflApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace idflApp.Controllers.Common
{
    [ApiController]
    [Authorize]
    [Route("api/authenticate")]
    public class AuthenticateController : ControllerBase
    {
        private IUserRepository _userService;
        public AuthenticateController(IUserRepository userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate([FromBody] AuthenticateRequestDto model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [HttpGet]
        [Authorize(Role.management)]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}