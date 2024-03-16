using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class DepartmentModel : BaseInterface
    {
        public string DepartmentName { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public List<UserModel>? UserModels { get; set; }
    }
}
