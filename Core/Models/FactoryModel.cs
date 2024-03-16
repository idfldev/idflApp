using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class FactoryModel : BaseInterface
    {
        public Guid ProjectId { get; set; }
        public ProjectModel ProjectModel { get; set; }
        public string? UnitName { get; set; }
        public string? Address { get; set; }
        public string? Ward { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? ZipCode { get; set; }
        public string? Occupancies { get; set; }
        public string? ActivitiesList { get; set; }
        public bool IsCertificatePreviously { get; set; }
        public List<BookModel>? BookModels { get; set; }

    }
}
