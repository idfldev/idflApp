using idflApp.auth;
using idflApp.Core.Dtos;
using idflApp.Core.Models;
using idflApp.Core.Models.Interfaces;
using idflApp.Services.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Management
{
    [ApiController]
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
                .PaginateAllAsync(pageNumber, pageSize, s => new FindProjectDto
                {
                    Id = s.Id,
                    Standard = s.StandardModel != null ? s.StandardModel.StandardCode + "-" + s.StandardModel!.Name : "",
                    IdflCode = s.IdflCode != null ? s.IdflCode : "",
                    Client = s.ClientModel != null ? s.ClientModel!.AccountName : "",
                    IsInitialCertification = s.IsInitialCertification,
                    IsRenewalCertification = s.IsRenewalCertification,
                    IsAnotherCertification = s.IsAnotherCertification,
                    LicenseNo = s.LicenseNo,
                    Books = s.BookModels
                   .Select(s => new BookingDto
                   {
                       Id = s.Id.ToString(),
                       IsBooked = s.IsBooked,
                       StartedDate = s.StartDate.ToString("dd/MMM/yy"),
                       EndedDate = s.EndDate.ToString("dd/MMM/yy")
                   }).ToList(),
                    CertificationBody = s.CertificationBody != null ? s.CertificationBody : "",
                    CertificationExpirationDate = s.CertificationExpirationDate.ToString("dd/MMM/yy"),
                    Status = s.Status != null ? s.Status.ToString() : "",
                    IssueCertificated = s.IssueCertificated,
                    IssueCertificatedDate = s.IssueCertificatedDate.ToString() != null ? s.IssueCertificatedDate.ToString("dd/MMM/yy") : "",
                }, x => x.StandardModel!, x => x.ClientModel!, x => x.BookModels!);
            if (projectResult != null)
            {

                return Ok(projectResult);

            }
            _logger.LogWarning("Find controller-Project not found: ", projectResult);
            return NotFound();
        }
        //TODO: Create Project
        //TODO: Get Detail
        //TODO: Update Project
    }
}