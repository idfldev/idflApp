using System.Text.Json.Serialization;
using Core.Models.Intefaces;
using idflApp.Constants;
using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class UserModel : AccountModel
    {
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public string? Icon { get; set; }
        public Role Roles { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public bool IsDeleted { get; set; }
        public List<BookModel>? BookModels { get; set; }
        public DateTime? ActiveDateAt { get; set; }
        public DateTime? VerifiedDateAt { get; set; }
        public DateTime? DeletedDateAt { get; set; }
        public List<ProjectModel>? ProjectModels { get; set; }
    }
}