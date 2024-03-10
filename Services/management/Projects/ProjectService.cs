using AutoMapper;
using idflApp.Core.Dtos;
using idflApp.Core.Models;
using idflApp.Data;
using idflApp.Services.management.Projects.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace idflApp.Services.management.Projects
{
    public class ProjectService : IProjectRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ProjectService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IEnumerable<FindProjectDto> Find()
        {
            var projects = _context.Project
                .Include(c => c.StandardModel)
                .Include(c => c.ClientModel)
                .Include(c => c.BookModels)
                .Select(s => new FindProjectDto
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
                        Purpose = s.Purpose,
                        IsBooked = s.IsBooked,
                        StartedDate = s.StartedAt.ToString("dd/MMM/yy"),
                        EndedDate = s.EndedAt.ToString("dd/MMM/yy")
                    }).ToList() : null,
                    CertificationBody = s.CertificationBody != null ? s.CertificationBody : "",
                    CertificationExpirationDate = s.CertificationExpirationDate.ToString("dd/MMM/yy"),
                    Status = s.Status != null ? s.Status.ToString() : "",
                    IssueCertificated = s.IssueCertificated,
                    IssueCertificatedDate = s.IssueCertificatedDate.ToString() != null ? s.IssueCertificatedDate.ToString("dd/MMM/yy") : "",
                }).ToList();

            return projects;
        }

        public GetProjectDetailDto GetDetailById(Guid id)
        {
            var project = _context.Project
            .Include(c => c.StandardModel)
            .Include(c => c.BookModels)
            .Include(c => c.BookModels)
            .Include(c => c.ClientModel)
            .Include(c => c.StandardAnswerModels)
            .Include(c => c.ProjectGeneralModel)
            .Where(s => s.Id.Equals(id)).First();
            if (project != null)
            {
                var projects = new GetProjectDetailDto
                {
                    Id = project.Id.ToString(),
                    IdflCode = project != null ? project.IdflCode : "",
                    IsInitialCertification = project.IsInitialCertification,
                    IsRenewalCertification = project.IsRenewalCertification,
                    IsAnotherCertification = project.IsAnotherCertification,
                    LicenseNo = project != null ? project.LicenseNo : "",
                    CertificationBody = project != null ? project.CertificationBody : "",
                    CertificationExpirationDate = project != null ? project.CertificationExpirationDate.ToString("dd/MMM/yy") : "",
                    Status = project != null ? project.Status : "",
                    IssueCertificated = project.IssueCertificated,
                    IssueCertificatedDate = project != null ? project.IssueCertificatedDate.ToString("dd/MMM/yy") : "",
                    Standard = new StandardDto
                    {
                        Id = project.StandardModel != null ? project.StandardModel.Id.ToString() : "",
                        Name = project.StandardModel != null ? project.StandardModel.Name : "",
                        StandardCode = project.StandardModel != null ? project.StandardModel.StandardCode : ""
                    },
                    Books = project.BookModels != null ? project.BookModels.Select(s => new BookDto
                    {
                        Id = s.Id.ToString(),
                        Purpose = s.Purpose,
                        AuditName = _context.User.Where(i => i.Id.Equals(s.AuditBy)).Select(s => s.AccountName).First(),
                        CompletedNotes = s.CompletedNotes,
                        Description = s.Description,
                        CompletedAt = s.CompletedAt.ToString("dd/MMM/yy"),
                        StartedAt = s.StartedAt.ToString("dd/MMM/yy"),
                        EndedAt = s.EndedAt.ToString("dd/MMM/yy"),
                    }).ToList() : null,
                    Client = new ClientDto
                    {
                        Id = project.ClientId.ToString(),
                        CompanyName =project.ClientModel != null ? project.ClientModel.CompanyName : "",
                        BusinessLicenseFile = project.ClientModel != null ? project.ClientModel.BusinessLicenseFile : "",
                        Representator = project.ClientModel != null ? project.ClientModel.Representator: "",
                        RepresentatorTitle = project.ClientModel != null ? project.ClientModel.RepresentatorTitle : "",
                        ContactPerson = project.ClientModel != null ? project.ClientModel.ContactPerson : "",
                        IsThirdParty =project.ClientModel != null ? project.ClientModel.IsThirdParty : false
                    }

                };
                return projects;
            }
            return null;
        }

    }
}