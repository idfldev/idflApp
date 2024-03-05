using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class BookModel : ContentModel
    {
        public Guid UserId { get; set; }
        public UserModel UserModel { get; set; }
        public Guid? ProjectId { get; set; }
        public ProjectModel? ProjectModel { get; set; }
        public Guid? AuditById { get; set; }
        public Guid? CompletedById { get; set; }
        public string? Subject { get; set; }
        public DateTime AuditDateAt { get; set; }
        public DateTime CompletedAt { get; set; }
        public DateTime BookedAt { get; set; }
    }
}
