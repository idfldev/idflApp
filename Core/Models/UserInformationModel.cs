using idflApp.Constants;
using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class UserInformationModel : BaseInterface
    {
        public Guid UserId { get; set; }
        public UserModel? UserModel { get; set; }
        public string? City { get; set; }
        public string? Title { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime Dob { get; set; }
    }
}
