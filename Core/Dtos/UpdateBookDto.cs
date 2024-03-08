using idflApp.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace idflApp.Core.Dtos
{
    public class UpdateBookDto
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public UpdateBook Data { get; set; }
    }
    public class UpdateBook
    {
        [Required]
        public Guid BookId { get; set; }
        [Required]
        public Guid ProjectId { get; set; }
        [Required]
        public Guid AuditById { get; set; }
        public string? Purpose { get; set; }
        public string? Description { get; set; }
        [Required]
        public DateTime StartedAt { get; set; }
        [Required]
        public DateTime EndedAt { get; set; }
    }
}
