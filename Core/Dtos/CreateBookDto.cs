using idflApp.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace idflApp.Core.Dtos
{
    public class CreateBooKResponseDto
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public CreateBookRequestDto Data { get; set; }
    }
    public class CreateBookRequestDto
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid FactoryId { get; set; }
        [Required]
        public string Title { get; set; }
        public List<UserBookRequestDto>? UserBookRequest { get; set; }
        [Required]
        public string SubTitle { get; set; }
        public string? BgColor { get; set; }
        public int? Occupancy { get; set; }
        public string? Description { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

    }
    public class UserBookRequestDto
    {
        public Guid AuditorId { get; set; }
        public Guid BookId { get; set; }
    }
}
