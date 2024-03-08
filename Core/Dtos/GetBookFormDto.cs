namespace idflApp.Core.Dtos
{
    public class GetBookFormDto
    {
        public string Id { get; set; }  
        public string? Client { get; set; }
        public string? Standard { get; set; }
        public string? Status { get; set; }
        public List<Auditors> Auditors { get; set; }
    }
    public class Auditors{
        public string Id { get; set; }
        public string Name { get; set; }
    }
}