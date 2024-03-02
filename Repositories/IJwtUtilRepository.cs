using idflApp.Core.Models;

namespace idflApp.Repository
{
    public interface IJwtUtilRepository
    {
        public string GenerateJwtToken(UserModel user);
        public Guid? ValidateJwtToken(string? token);
    }
}