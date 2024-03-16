using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using idflApp.Constants;
using idflApp.Core.Models;

namespace idflApp.auth
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private readonly IList<Role> _roles;
        public AuthorizeAttribute(params Role[] roles)
        {
            _roles = roles ?? new Role[] { };
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // skip authorization if action is decorated with [AllowAnonymous] attribute
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
                return;

            // authorization
            var user = (UserModel?)context.HttpContext.Items["User"];
            if (user == null)
            {
                // User is not logged in
                context.Result = new JsonResult(new { message = "Unauthorized - User not logged in" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
            else if (_roles.Any() && !_roles.Contains(user.UserRole))
            {
                // User is logged in but doesn't have the required role
                context.Result = new JsonResult(new { message = "Unauthorized - Insufficient Role Access" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }

        }
    }
}
