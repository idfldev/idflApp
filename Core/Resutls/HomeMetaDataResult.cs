namespace idflApp.Core.Resutls
{
    public class HomeMetaDataResult
    {
        public List<SessionBannerResult> SessionBanners { get; set; }
        public SessionServiceResult SessionServices { get; set; }
        public List<SessionServiceStandardResult> SessionServiceStandard { get; set; }
    }
    public class SessionBannerResult
    {
        public string? Url { get; set; }
    }
    public class SessionServiceResult
    {
        public string? Header { get; set; }
        public string? SubHeader { get; set; }
    }
    public class SessionServiceStandardResult
    {
        public Guid Id { get; set; }
        public string? Url { get; set; }
        public string? Name { get; set; }
        public List<string> Icons { get; set; }
    }
}