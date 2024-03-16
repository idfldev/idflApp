using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class StandardModel: BaseInterface
    {
        public string? Displayname { get; set; }
        public string? StandardCode { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        public List<ProjectModel>? ProjectModels { get; set; }
    }
}
