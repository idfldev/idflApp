using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class ClientInfomationModel : BaseInterface
    {
        public Guid ClientId { get; set; } // Foreign key
        public required ClientModel ClientModel { get; set; }
        public required string CompanyName { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? ContactPerson { get; set; }
        public string? Title { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? DeskPhone { get; set; }
        public DateTime Dob { get; set; }

    }
}
