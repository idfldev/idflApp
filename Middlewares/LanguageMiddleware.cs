
using idflApp.Constants;

namespace idflApp.Middlewares
{
    public class LanguageMiddleware
    {
        private readonly RequestDelegate _next;
        public LanguageMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public Task Invoke(HttpContext httpContext)
        {
            var Language = GetCurrentLanguage(httpContext);
            httpContext.Request.QueryString = httpContext.Request.QueryString.Add("Language", Language);
            return _next(httpContext);
        }

        static string GetCurrentLanguage(HttpContext httpContext)
        {
            httpContext.Request.Headers.TryGetValue("language", out var valueHeader);
            return valueHeader.FirstOrDefault(LanguageConstant.LangValue.vi.ToString())!;
        }

    }

    public static class MyMiddlewareExtensions
    { 
        public static IApplicationBuilder UseMyMiddeware(IApplicationBuilder builder){
            return builder.UseMiddleware<LanguageMiddleware>();
        }
    }
}