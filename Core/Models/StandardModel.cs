using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class StandardModel: ContentModel
    {
        public string? StandardCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public List<ProjectModel>? ProjectModels { get; set; }
        public List<StandardQuestionModel>? StandardQuestionModels { get; set; }
    }
}
