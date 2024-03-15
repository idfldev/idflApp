using System.Text.Json.Serialization;
using idflApp.Constants;
using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class UserModel : BaseInterface
    {
        public string? DisplayName { get; set; }
        public string UserCode { get; set; }
        public Role UserRole { get; set; }
        [JsonIgnore]
        public required string Password { get; set; }
        public bool IsVerified { get; set; }
        public bool IsActive { get; set; }
        public bool Status { get; set; }
        public Guid DepartmentId { get; set; }
        public DepartmentModel? DepartmentModel { get; set; }
        public List<ProjectModel>? ProjectModels { get; set; }
        public List<UserInformationModel>? UserInformationModels { get; set; }
        public List<BookUserModel>? BookUserModels { get; set; }
        public List<BookCompleteModel>? BookCompleteModels { get; set; }
        public List<AccountVerifyModel>? AccountVerifyModels { get; set; }

    }
}