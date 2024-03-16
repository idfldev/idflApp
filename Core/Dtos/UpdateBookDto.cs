using idflApp.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace idflApp.Core.Dtos
{
     public class UpdateBooKResponseDto
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public UpdateBookRequestDto Data { get; set; }
    }
    public class UpdateBookRequestDto
    {
        public string Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string FactoryId { get; set; }
        [Required]
        public string Title { get; set; }
        public List<UpdateUserBookRequestDto>? UserBookRequest { get; set; }
        [Required]
        public string SubTitle { get; set; }
        public string? BgColor { get; set; }
        public int? Occupancy { get; set; }
        public string? Description { get; set; }
        [Required]
        public DateTime UpdateddAt { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

    }
    public class UpdateUserBookRequestDto
    {
        public string AuditorId { get; set; }
        public string BookId { get; set; }
    }
}
