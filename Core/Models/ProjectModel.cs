using Core.Models;
using idflApp.Core.Models.Interfaces;


namespace idflApp.Core.Models
{
    public class ProjectModel : BaseInterface
    {
        public string? RefCode { get; set; }
        public string? CertificationNumber { get; set; }
        public string? CertificationBody { get; set; }
        public string? Status { get; set; }
        //relationship
        public Guid ClientId { get; set; }
        public required ClientModel ClientModel { get; set; }
        public Guid? UserId { get; set; }
        public UserModel? UserModel { get; set; }
        public Guid? StandardId { get; set; }
        public StandardModel? StandardModel { get; set; }
        // end relationship
        public DateTime IssueCertificatedDate { get; set; }
        public DateTime CertificationExpirationDate { get; set; }
        public List<FactoryModel> FactoryModels{ get; set; }
    }
}

