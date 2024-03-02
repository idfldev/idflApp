using System.Text.Json.Serialization;
using idflApp.Constants;
using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class UserModel : BaseInterface
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Role Roles { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsVerified { get; set; }
        [JsonIgnore]
        public required string Password { get; set; }
    }
}