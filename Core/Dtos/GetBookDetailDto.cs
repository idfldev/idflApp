using idflApp.Core.Models;

namespace idflApp.Core.Dtos
{
    public class GetBookDetailDto
    {
        public Guid BookId { get; set; }
        public HandleBy? UserAccount { get; set; }
        public Project? Project { get; set; }
        public Audit? AuditAccount { get; set; }
        public CompletedBy? CompletedAccount { get; set; }
        public string? Subject { get; set; }
        public string? CompletedAt { get; set; }
        public string? StartedAt { get; set; }
        public string? EndedAt { get; set; }
    }
    public class HandleBy
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
    }
    public class Project
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
    }
    public class Audit
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
    }
    public class CompletedBy
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
    }
}
