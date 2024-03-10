namespace idflApp.Core.Dtos
{
    public class GetProjectDetailDto
    {
        public string? Id { get; set; }
        public string? IdflCode { get; set; }
        public bool IsInitialCertification { get; set; }
        public bool IsRenewalCertification { get; set; }
        public bool IsAnotherCertification { get; set; }
        public string? LicenseNo { get; set; }
        public string? CertificationBody { get; set; }
        public string? CertificationExpirationDate { get; set; }
        public string? Status { get; set; }
        public bool IssueCertificated { get; set; }
        public string? IssueCertificatedDate { get; set; }
        public ProjectGeneral? ProjectGeneral { get; set; }
        public StandardDto? Standard{ get; set; }
        public List<BookDto>? Books { get; set; }
        public ClientDto? Client { get; set; }
    }

    public class StandardDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? StandardCode { get; set; }
    }
    public class BookDto
    {
        public string? Id { get; set; }
        public string? Purpose { get; set; }
        public string? AuditName { get; set; }
        public string? CompletedNotes { get; set; }
        public string? Description { get; set; }
        public string? CompletedAt { get; set; }
        public string? StartedAt { get; set; }
        public string? EndedAt { get; set; }

    }
    public class ClientDto
    {
        public string? Id { get; set; }
        public string? CompanyName { get; set; }
        public string? BusinessLicenseFile { get; set; }
        public string? Representator { get; set; }
        public string? RepresentatorTitle { get; set; }
        public string? ContactPerson { get; set; }
        public bool IsThirdParty { get; set; }
    }
    public class ProjectGeneral
    {
        public string? Id { get; set; }
        public int ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public int? ClientNumber { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsRushCertificate { get; set; }
        public string? DeniedCertificationDescription { get; set; }
    }
}