namespace idflApp.Core.Resutls
{
    public class GetDetailProjectResult
    {
        public string? CertificationBody { get; set; }
        public string? Status { get; set; }
        public DateTime IssueCertificatedDate { get; set; }
        public DateTime CertificationExpirationDate { get; set; }
        public GetClientDetailResult? GetClientResult { get; set; }
        public GetStandardDetailResult? GetStandardResult { get; set; }
        // end relationship

        public List<GetFactoryDetailResult> GetFactoryDetailResult { get; set; }
    }
    public class GetClientDetailResult
    {
        public string Id { get; set; }
        public string? Email { get; set; }
        public bool IsThirdParty { get; set; }

        public List<GetClienInfortDetailResult>? GetClienInfortDetailResult { get; set; }
    }
    public class GetClienInfortDetailResult
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? ContactPerson { get; set; }
        public string? Title { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }

    }
    public class GetStandardDetailResult
    {
        public string Id { get; set; }
        public string? Displayname { get; set; }
        public string? StandardCode { get; set; }
    }
    public class GetFactoryDetailResult
    {
        public string Id { get; set; }
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
        public GetBookDetailResult? GetBookDetailResult { get; set; }
    }
    public class GetBookDetailResult
    {
        public string Id { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public int? Occupancy { get; set; }
        public string? CompletedNotes { get; set; }
        public string? Description { get; set; }
        public DateTime CompletedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}