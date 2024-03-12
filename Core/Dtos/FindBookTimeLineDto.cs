namespace idflApp.Core.Dtos
{
    public class FindBookTimeLineDto
    {
        public string Id { get; set; }
        public Label Label { get; set; }
        public List<BookingData> Data { get; set; }
    }
    public class Label
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string? Subtitle { get; set; }
    }

    public class BookingData
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Occupancy { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string? Description { get; set; }
        public string? BgColor { get; set; }
    }

}
