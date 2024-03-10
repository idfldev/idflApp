namespace idflApp.Core.Dtos
{
    public class FindProjectDto
    {
        public Guid Id { get; set; }
        public string? IdflCode { get; set; }
        public string? Standard { get; set; }
        public string? Client { get; set; }
        public List<BookingDto>? Books { get; set; }
        public bool IsInitialCertification { get; set; }
        public bool IsRenewalCertification { get; set; }
        public bool IsAnotherCertification { get; set; }
        public string? LicenseNo { get; set; }
        public string? CertificationBody { get; set; }
        public string? CertificationExpirationDate { get; set; }
        public string? Status { get; set; }
        public bool IssueCertificated { get; set; }
        public string? IssueCertificatedDate { get; set; }
    }
    public class BookingDto
    {
        public string? Id { get; set; }
        public string? Purpose { get; set; }
        public bool? IsBooked { get; set; }
        public string? StartedDate { get; set; }
        public string? EndedDate { get; set; }
    }
}