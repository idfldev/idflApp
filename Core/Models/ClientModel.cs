using System.Text.Json.Serialization;
using Core.Models.Intefaces;
using idflApp.Constants;
using idflApp.Core.Models;

namespace Core.Models
{
    public class ClientModel : AccountModel
    {
        public int AccountNumber { get; set; }
        public ClientRole AccountRole { get; set; }
        public string CompanyName { get; set; }
        public string BusinessLicenseFile { get; set; }
        public string? TaxNumber { get; set; }
        public string Representator { get; set; }
        public string? RepresentatorTitle { get; set; }
        public string IDCardNumber { get; set; }
        public string ContactPerson { get; set; }
        public bool IsThirdParty { get; set; }
        public string? Website { get; set; }
        public string? FaxNumber { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? ActiveAt { get; set; }
        public DateTime? VerifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public List<ProjectModel>? ProjectModels { get; set; }
    }
}