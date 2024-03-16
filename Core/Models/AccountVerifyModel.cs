using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class AccountVerifyModel : BaseInterface
    {
        public Guid UserId { get; set; } // Foreign key
        public UserModel? UserModel { get; set; }
        public Guid ClientId { get; set; } // Foreign key
        public ClientModel? ClientModel { get; set; } // Foreign key
        public double VerifyCode { get; set; }
        public int VerifyCount { get; set; }
        public DateTime StartedTime { get; set; }
    }
}
