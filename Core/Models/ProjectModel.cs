using Core.Models;
using idflApp.Core.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace idflApp.Core.Models
{
    public class ProjectModel : BaseInterface
    {
        public Guid StandardId { get; set; }
        public StandardModel? StandardModel { get; set; }
        public Guid ClientId { get; set; }
        public List<ProjectStandardModel>? ProjectStandardModels { get; set; }
        public Guid? ProjectGeneralId { get; set; }
        public ProjectGeneralModel? ProjectGeneralModel { get; set; }
        public ClientModel? ClientModel { get; set; }
        public Guid? PayerId { get; set; }
        public Guid? BookId { get; set; }
        public BookModel? BookModel { get; set; }
        public bool IsInitialCertification { get; set; }
        public bool IsRenewalCertification { get; set; }
        public bool IsAnotherCertification { get; set; }
        public bool IsRequired { get; set; }
        public string? LicenseNo { get; set; }
        public string? CertificationBody { get; set; }
        public DateTime? CertificationExpirationDate { get; set; }
        public bool IsDeleted { get; set; }
        public byte Status { get; set; }
        public bool IsActive { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsCertificated { get; set; }
        public Guid? ConfirmedByUserId { get; set; }
        public DateTime? ConfirmedDateAt { get; set; }
        public DateTime? CertificatedDate { get; set; }
        public DateTime? ActiveDateAt { get; set; }
        public DateTime? DeletedDateAt { get; set; }
        public List<StandardAnswerModel>? StandardAnswerModels { get; set; }
    }
}

