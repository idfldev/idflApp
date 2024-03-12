using idflApp.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace idflApp.Core.Dtos
{
    public class CreateBooKDto
    {
        public bool Result { get; set; }
        public string Message { get; set; }
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
        [Required]
        public string Title { get; set; }
        [Required]
        public string SubTitle { get; set; }
        public string? BgColor { get; set; }
        public string? Occupancy { get; set; }
        public string? Description { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

    }
}
