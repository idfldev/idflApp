using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class BookUserModel : BaseInterface
    {
        public Guid AuditorId { get; set; }
        public UserModel? UserModel { get; set; }
        public Guid BookId { get; set; }
        public BookModel? BookModel { get; set; }
    }

}