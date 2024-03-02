
using idflApp.Core.Dtos;
using idflApp.Core.Models;
using idflApp.Core.Resutls;

namespace idflApp.Repository
{
    public interface IUserRepository
    {
        AuthenticateResponseResult? Authenticate(AuthenticateRequestDto model);
        IEnumerable<UserModel> GetAll();
        UserModel? GetById(Guid id);
    }
}