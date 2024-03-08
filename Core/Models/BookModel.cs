using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class BookModel : BaseInterface
    {
        public string? Purpose { get; set; }
        public Guid UserId { get; set; }
        public UserModel UserModel { get; set; }
        public Guid? ProjectId { get; set; }
        public ProjectModel? ProjectModel { get; set; }
        public Guid? AuditBy { get; set; }
        public Guid? CompletedBy { get; set; }
        public string? CompletedNotes { get; set; }
        public string? Description { get; set; }
        public DateTime CompletedAt { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
    }
}
