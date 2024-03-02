using System.Text.Json.Serialization;
using idflApp.Constants;
using idflApp.Core.Dtos;
using idflApp.Data;
using idflApp.Middlewares;
using idflApp.Repository;
using idflApp.Services;
using idflApp.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddCors();
builder.Services.AddControllers()
 .AddJsonOptions(options =>
  {
      options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
  });
// configure databsae
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppJwtSettings"));
builder.Services.AddAntiforgery(options =>
{
    options.HeaderName = KeyConstant.CsrfHeader;
});
builder.Services.AddScoped<IJwtUtilRepository, JwtUtils>();
builder.Services.AddScoped<IUserRepository, UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
var path = app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "Uploads"))
    ,
    RequestPath = "/images"
});
app.UseRouting();
//Auth
app.UseAuthentication();
app.UseAuthorization();
//Add Cors
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
MyMiddlewareExtensions.UseMyMiddeware(app);
app.UseMiddleware<LanguageMiddleware>();
app.UseMiddleware<JwtMiddleware>();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
