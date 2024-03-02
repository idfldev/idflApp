
using idflApp.Core.Dtos;
using idflApp.Core.Models;
using idflApp.Core.Resutls;
using idflApp.Data;
using idflApp.Repository;

namespace idflApp.Services
{
    public class UserService : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IJwtUtilRepository _jwtUtils;

        public UserService(IJwtUtilRepository jwtUtils, ApplicationDbContext context)
        {
            _jwtUtils = jwtUtils;
            _context = context;
        }
        public AuthenticateResponseResult? Authenticate(AuthenticateRequestDto model)
        {
            var user = _context.User.FirstOrDefault(x => x.Email == model.Email);

            // return null if user not found
            if (user == null) return null;
            var decryptPassword = Utils.HashPasswordUtils.DecryptCode(user.Password);
            if (decryptPassword == null) return null;
            if (decryptPassword != model.Password) return null;

            // authentication successful so generate jwt token
            var token = _jwtUtils.GenerateJwtToken(user);

            return new AuthenticateResponseResult(user, token);
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _context.User.ToList();
        }

        public UserModel? GetById(Guid id)
        {
            return _context.User.FirstOrDefault(x => x.Id == id);
        }
    }
}