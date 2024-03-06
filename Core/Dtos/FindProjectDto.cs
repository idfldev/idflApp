using Core.Models;
using idflApp.Constants;
using idflApp.Core.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using static idflApp.Constants.ProjectConstant;

namespace idflApp.Core.Dtos
{
    public class FindProjectDto
    {
        public Guid Id { get; set; }
        public string? IdflCode { get; set; }
        public List<UserDto> Users { get; set; }
        public string? Standard { get; set; }
        public Guid? BookId { get; set; }
        public string? Client { get; set; }
        public bool IsInitialCertification { get; set; }
        public bool IsRenewalCertification { get; set; }
        public bool IsAnotherCertification { get; set; }
        public string? LicenseNo { get; set; }
        public string? CertificationBody { get; set; }
        public string? CertificationExpirationDate { get; set; } = string.Empty;
        public string? Status { get; set; }
        public string? HandledBy { get; set; }
        public bool IssueCertificated { get; set; }
        public string? IssueCertificatedDate { get; set; }
    }
    public class UserDto{
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}