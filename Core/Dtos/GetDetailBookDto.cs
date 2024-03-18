using idflApp.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace idflApp.Core.Dtos
{
     public class GetDetailBooKResponseDto
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public GetDetailBookRequestDto Data { get; set; }
    }
    public class GetDetailBookRequestDto
    {
        public string Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string FactoryId { get; set; }
        [Required]
        public string Title { get; set; }
        public List<GetDetailUserBookRequestDto>? UserBookRequest { get; set; }
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
    public class GetDetailUserBookRequestDto
    {
        public string Id { get; set; }
        public string AuditorId { get; set; }
        public string BookId { get; set; }
    }
}
