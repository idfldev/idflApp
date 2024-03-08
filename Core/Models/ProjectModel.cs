using Core.Models;
using idflApp.Core.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using static idflApp.Constants.ProjectConstant;

namespace idflApp.Core.Models
{
    public class ProjectModel : BaseInterface
    {
        public Guid StandardId { get; set; }
        public string? IdflCode { get; set; }
        public StandardModel? StandardModel { get; set; }
        public Guid? BookId { get; set; }
        public BookModel? BookModel { get; set; }
        public Guid ClientId { get; set; }
        public List<ProjectStandardModel>? ProjectStandardModels { get; set; }
        public Guid? ProjectGeneralId { get; set; }
        public ProjectGeneralModel? ProjectGeneralModel { get; set; }
        public ClientModel? ClientModel { get; set; }
        public Guid? PayerId { get; set; }
        public bool IsInitialCertification { get; set; }
        public bool IsRenewalCertification { get; set; }
        public bool IsAnotherCertification { get; set; }
        public string? LicenseNo { get; set; }
        public string? CertificationBody { get; set; }
        public DateTime CertificationExpirationDate { get; set; }
        public bool IsDeleted { get; set; }
        public string? Status { get; set; }
        public Guid? HandledBy { get; set; }
        public UserModel UserModel { get; set; }
        public bool IssueCertificated { get; set; }
        public DateTime IssueCertificatedDate { get; set; }
        public List<StandardAnswerModel>? StandardAnswerModels { get; set; }
    }
}

