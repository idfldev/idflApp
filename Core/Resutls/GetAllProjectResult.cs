namespace idflApp.Core.Resutls
{
    public class GetAllProjectResult
    {
        public string Id { get; set; }
        public string? RefCode { get; set; }
        public string? Standard { get; set; }
        public string? CompanyName { get; set; }
        public string? CertificationNumber { get; set; }
        public string? CertificationBody { get; set; }
        public string? Status { get; set; }
        public string? IssueCertificatedDate { get; set; }
        public string? CertificationExpirationDate { get; set; }
        public List<GetFactoryResult>? GetFactoryResult { get; set; }
    }
    public class GetFactoryResult
    {
        public string Id { get; set; }
        public string? UnitName { get; set; }
    }
}