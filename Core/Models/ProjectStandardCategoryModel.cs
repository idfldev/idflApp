using idflApp.Core.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace idflApp.Core.Models
{
    public class ProjectStandardCategoryModel : ContentModel
    {
        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
        public List<ProjectStandardModel>? ProjectStandardModels { get; set; }
    }
}
