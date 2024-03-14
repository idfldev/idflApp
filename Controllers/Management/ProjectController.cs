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
        private readonly IRepository<ProjectModel> _repositoyProject;
        public ProjectController(IRepository<ProjectModel> repositoyProject, ILogger<ProjectController> logger)
        {
            _repositoyProject = repositoyProject;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Find([FromQuery] IParams @params)
        {
            var pageNumber = 1;
            var pageSize = 50;
            var projectResult = await _repositoyProject
                .PaginationGetAllAsync(pageNumber, pageSize,
                x => x.StandardModel!,
                x => x.ClientModel!,
                x => x.BookModels!);
            if (projectResult != null)
            {
                var project = projectResult.Data.Select(s => new FindProjectDto
                {
                    Id = s.Id,
                    Standard = s.StandardModel != null ? s.StandardModel.StandardCode + "-" + s.StandardModel!.Name : "",
                    IdflCode = s.IdflCode != null ? s.IdflCode : "",
                    Client = s.ClientModel != null ? s.ClientModel!.AccountName : "",
                    IsInitialCertification = s.IsInitialCertification,
                    IsRenewalCertification = s.IsRenewalCertification,
                    IsAnotherCertification = s.IsAnotherCertification,
                    LicenseNo = s.LicenseNo,
                    Books = s.BookModels != null ? s.BookModels
               .Select(s => new BookingDto
               {
                   Id = s.Id.ToString(),
                   IsBooked = s.IsBooked,
                   StartedDate = s.StartDate.ToString("dd/MMM/yy"),
                   EndedDate = s.EndDate.ToString("dd/MMM/yy")
               }).ToList() : null,
                    CertificationBody = s.CertificationBody != null ? s.CertificationBody : "",
                    CertificationExpirationDate = s.CertificationExpirationDate.ToString("dd/MMM/yy"),
                    Status = s.Status != null ? s.Status.ToString() : "",
                    IssueCertificated = s.IssueCertificated,
                    IssueCertificatedDate = s.IssueCertificatedDate.ToString() != null ? s.IssueCertificatedDate.ToString("dd/MMM/yy") : "",
                }).ToList();
                return Ok(new
                {
                    Pagination = new IParams
                    {
                        PageNumber = projectResult.PageNumber,
                        PageSize = projectResult.PageSize,
                        FirstPage = projectResult.FirstPage,
                        LastPage = projectResult.LastPage,
                        TotalPages = projectResult.TotalPages,
                        TotalRecords = projectResult.TotalRecords,
                        NextPage = projectResult.NextPage,
                        PreviousPage = projectResult.PreviousPage

                    },
                    project
                });

            }
            _logger.LogWarning("Find controller-Project not found: ", projectResult);
            return NotFound();
        }
        //TODO: Create Project
        //TODO: Get Detail
        //TODO: Update Project
    }
}