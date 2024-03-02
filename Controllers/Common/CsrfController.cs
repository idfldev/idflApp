using idflApp.Constants;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;

namespace idflApp.Controllers.Common
{
    [ApiController]
    [Route("api/antiforgery")]
    public class CsrfController : ControllerBase
    {
        private readonly ILogger<CsrfController> _logger;
        public CsrfController(ILogger<CsrfController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult CreateToken([FromServices] IAntiforgery forgeryService)
        {
            return Ok("csrfToken: "+ BuildTokenCsrf(forgeryService));
        }
        public string BuildTokenCsrf(IAntiforgery antiforgery)
        {
            
            var context = HttpContext;
            {
                var tokens = antiforgery.GetAndStoreTokens(context);
                context.Response.Cookies.Append(KeyConstant.CsrfHeader, tokens.RequestToken!,
                new CookieOptions { HttpOnly = false });
                return tokens.RequestToken!;
            };
            
        }
    }
}