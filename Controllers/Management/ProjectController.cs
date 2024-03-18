using System.Linq.Expressions;
using idflApp.auth;
using idflApp.Core.Dtos;
using idflApp.Core.Models;
using idflApp.Core.Models.Interfaces;
using idflApp.Core.Resutls;
using idflApp.Services.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Management
{
    [ApiController]
    [Authorize]
    [Route("api/management/project")]
    public class ProjectController : ControllerBase
    {
        private readonly ILogger<ProjectController> _logger;
        private readonly IRepository<ProjectModel, object> _repositoyProject;
        public ProjectController(IRepository<ProjectModel, object> repositoyProject, ILogger<ProjectController> logger)
        {
            _repositoyProject = repositoyProject;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Find([FromQuery] IParams @params)
        {
            var pageNumber = @params.PageNumber;
            var pageSize = @params.PageSize;
            var projectResult = await _repositoyProject
                .PaginateAllAsync(pageNumber, pageSize, s => new GetAllProjectResult
                {
                    Id = s.Id.ToString(),
                    Standard = s.StandardModel != null ? s.StandardModel.StandardCode + "-" + s.StandardModel!.Displayname : "",
                    RefCode = s.RefCode != null ? s.RefCode : "",
                    CompanyName = s.ClientModel != null ? s.ClientModel.ClientInfomationModels.Select(s => s.CompanyName).First() : "",
                    CertificationBody = s.CertificationBody != null ? s.CertificationBody : "",
                    CertificationExpirationDate = s.CertificationExpirationDate.ToString("dd/MMM/yy"),
                    Status = s.Status != null ? s.Status.ToString() : "",
                    IssueCertificatedDate = s.IssueCertificatedDate.ToString() != null ? s.IssueCertificatedDate.ToString("dd/MMM/yy") : "",
                    GetFactoryResult = s.FactoryModels.Select(s => new GetFactoryResult
                    {
                        Id = s.Id.ToString(),
                        UnitName = s.UnitName
                    }).ToList()
                }, x => x.StandardModel!, x => x.ClientModel!, x => x.ClientModel!.ClientInfomationModels, x => x.FactoryModels);
            if (projectResult != null)
            {

                return Ok(projectResult);

            }
            _logger.LogWarning("Find controller-Project not found: ", projectResult);
            return NotFound();
        }
        //TODO: Create Project
        //TODO: Get Detail
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetail(Guid id)
        {
            Expression<Func<ProjectModel, bool>> filter = p => p.Id == id;
            var result = await _repositoyProject.GetDetailFilteredAsync(s => new GetDetailProjectResult
            {
                CertificationBody = s.CertificationBody != null ? s.CertificationBody : "",
                Status = s.Status != null ? s.Status : "",
                IssueCertificatedDate = s.IssueCertificatedDate,
                CertificationExpirationDate = s.CertificationExpirationDate,
                GetClientResult = new GetClientDetailResult
                {
                    Id = s.Id.ToString(),
                    Email = s.ClientModel != null ? s.ClientModel.Email : "",
                    IsThirdParty = s.ClientModel!.IsThirdParty,
                    GetClienInfortDetailResult = s.ClientModel!.ClientInfomationModels.Select(clientInfo => new GetClienInfortDetailResult
                    {
                        Id = clientInfo.Id.ToString(),
                        CompanyName = clientInfo.CompanyName,
                        Address = clientInfo.Address,
                        City = clientInfo.City,
                        ContactPerson = clientInfo.ContactPerson,
                        Country = clientInfo.Country,
                        Title = clientInfo.Title,
                        Phone = clientInfo.Phone
                    }).ToList()
                },
                GetStandardResult = new GetStandardDetailResult
                {
                    Id = s.Id.ToString(),
                    Displayname = s.StandardModel.Displayname ?? null,
                    StandardCode = s.StandardModel.StandardCode ?? null
                },
                GetFactoryDetailResult = s.FactoryModels.Select(factory => new GetFactoryDetailResult
                {
                    Id = factory.Id.ToString(),
                    UnitName = factory.UnitName ?? null,
                    Address = factory.Address ?? null,
                    Ward = factory.Ward ?? null,
                    District = factory.District ?? null,
                    City = factory.City ?? null,
                    Country = factory.Country ?? null,
                    ZipCode = factory.ZipCode ?? null,
                    Occupancies = factory.Occupancies ?? null,
                    ActivitiesList = factory.ActivitiesList ?? null,
                    IsCertificatePreviously = factory.IsCertificatePreviously,
                    GetBookDetailResult = factory.BookModels.Any() ? new GetBookDetailResult
                    {
                        Id = factory.BookModels.First().Id.ToString(),
                        Title = factory.BookModels.First().Title,
                        SubTitle = factory.BookModels.First().SubTitle,
                        Occupancy = factory.BookModels.First().Occupancy,
                        CompletedNotes = factory.BookModels.First().CompletedNotes,
                        Description = factory.BookModels.First().Description,
                        CompletedDate = factory.BookModels.First().CompletedDate,
                        StartDate = factory.BookModels.First().StartDate,
                        EndDate = factory.BookModels.First().EndDate
                    } : null
                }).ToList()

            }, filter, c=>c.ClientModel, c=>c.ClientModel.ClientInfomationModels, c=>c.FactoryModels);
            return Ok(result);
        }
        //TODO: Update Project
    }
}