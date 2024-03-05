using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class ProjectStandardModel : BaseInterface
    {

        public Guid? ProjectId { get; set; }
        public ProjectModel? ProjectModel { get; set; }

        public Guid? ProjectStandardCategoryId { get; set; }
        public ProjectStandardCategoryModel? ProjectStandardCategory { get; set; }

        public string? Description { get; set; }
    }
}
