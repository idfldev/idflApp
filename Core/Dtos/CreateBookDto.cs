using idflApp.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace idflApp.Core.Dtos
{
    public class CreateBooKDto
    {
        public bool Result { get; set; }
        public string Messages { get; set; }
        public CreateBook Data { get; set; }
    }
    public class CreateBook
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid ProjectId { get; set; }
        [Required]
        public Guid AuditBy { get; set; }
        public string? Subject { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } 
        [Required]
        public DateTime StartedAt { get; set; }
        [Required]
        public DateTime EndedAt { get; set; }

    }
}
