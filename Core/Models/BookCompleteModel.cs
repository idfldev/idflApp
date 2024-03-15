using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class BookCompleteModel: BaseInterface
    {
        public Guid UserId { get; set; }
        public UserModel? UserModel { get; set; }
        public required BookModel BookModel { get; set; }
        public string? Status { get; set; }
        public DateTime CompletedDate { get; set; }
        public string? Description { get; set; }
    }
}
