using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class BookModel : BaseInterface
    {
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public int? Occupancy { get; set; }
        public string? BgColor { get; set; }
        public Guid? FactoryId { get; set; }
        public FactoryModel? FactoryModel { get; set; }
        // public Guid? AuditBy { get; set; }
        public List<BookUserModel>? BookUserModels { get; set; }
        public List<BookCompleteModel>? BookCompleteModels { get; set; }
        public bool IsBooked { get; set; }
        public string? CompletedNotes { get; set; }
        public string? Description { get; set; }
        public DateTime CompletedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
