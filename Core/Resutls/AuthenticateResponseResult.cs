
using idflApp.Constants;
using idflApp.Core.Models;

namespace idflApp.Core.Resutls
{
    public class AuthenticateResponseResult

    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Role Roles { get; set; }
        public string Token { get; set; }


        public AuthenticateResponseResult(UserModel user, string token)
        {
            Id = user.Id;
            Name = user.Name;
            Email = user.Email;
            Roles =user.Roles;
            Token = token;
        }
    }
}