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
            var users = _context.User.Select(s => new UserDto
            {
                Id = s.Id,
                Name = s.AccountName
            }).ToList();
            var projects = _context.Project
                .Include(c => c.UserModel)
                .Include(c => c.StandardModel)
                .Include(c => c.ClientModel)
                .Include(c => c.BookModel)
                .Select(s => new FindProjectDto
                {
                    Id = s.Id,
                    Standard = s.StandardModel!.StandardCode + "-" + s.StandardModel!.Name,
                    BookId = s.BookId,
                    IdflCode = s.IdflCode,
                    Client = s.ClientModel!.AccountName,
                    IsInitialCertification = s.IsInitialCertification,
                    IsRenewalCertification = s.IsRenewalCertification,
                    IsAnotherCertification = s.IsAnotherCertification,
                    LicenseNo = s.LicenseNo,
                    Book = s.BookModel.Id != null ? true : false,
                    Users = users,
                    CertificationBody = s.CertificationBody,
                    CertificationExpirationDate = s.CertificationExpirationDate.ToString("dd/MMM/yyyy"),
                    Status = s.Status!.ToString(),
                    HandledBy = s.UserModel.AccountName,
                    IssueCertificated = s.IssueCertificated,
                    IssueCertificatedDate = s.IssueCertificatedDate.ToString("dd/MMM/yyyy"),
                }).ToList();

            return projects;
        }

        public GetProjectDetailDto GetDetailById(Guid id)
        {
            var project = _context.Project
            .Include(c => c.StandardModel)
            .Include(c => c.BookModel)
            .Include(c => c.ClientModel)
            .Include(c => c.StandardAnswerModels)
            .Include(c => c.ProjectGeneralModel)
            .Where(s => s.Id.Equals(id)).First();
            if (project != null)
            {

                var auditor = _context.User
                  .Where(s => s.Id.Equals(
                    project.BookModel != null ? project.BookModel.AuditBy : string.Empty))
                    .Select(s => new
                    {
                        s.Id,
                        s.AccountName
                    })
                    .FirstOrDefault()!;
                var completer = _context.User
                .Where(s => s.Id.Equals(
                    project.BookModel != null ? project.BookModel.CompletedBy : string.Empty))
                    .Select(s => new
                    {
                        s.Id,
                        s.AccountName
                    })
                    .FirstOrDefault()!;
                var projects = new GetProjectDetailDto
                {
                    Id = project.Id.ToString(),
                    IdflCode = project != null ? project.IdflCode : "",
                    IsInitialCertification = project.IsInitialCertification,
                    IsRenewalCertification = project.IsRenewalCertification,
                    IsAnotherCertification = project.IsAnotherCertification,
                    LicenseNo = project != null ? project.LicenseNo : "",
                    CertificationBody = project != null ? project.CertificationBody : "",
                    CertificationExpirationDate = project != null ? project.CertificationExpirationDate.ToString("dd/MMM/yyyy") : "",
                    Status = project != null ? project.Status : "",
                    IssueCertificated = project.IssueCertificated,
                    IssueCertificatedDate = project != null ? project.IssueCertificatedDate.ToString("dd/MMM/yyyy") : "",
                    StandardDto = new StandardDto
                    {
                        Id = project.StandardModel != null ? project.StandardModel.Id.ToString() : "",
                        Name = project.StandardModel != null ? project.StandardModel.Name : "",
                        StandardCode = project.StandardModel != null ? project.StandardModel.StandardCode : ""
                    },
                    BookDto = new BookDto
                    {
                        Id = project.BookModel != null ? project.BookModel.Id.ToString() : "",
                        Purpose = project.BookModel != null ? project.BookModel!.Purpose : "",
                        AuditName = auditor != null ? auditor!.AccountName : "",
                        CompletedName = completer != null ? completer!.AccountName : "",
                        CompletedNotes = project.BookModel != null ? project.BookModel.CompletedNotes : "",
                        Description = project.BookModel != null ? project.BookModel.Description : "",
                        CompletedAt = project.BookModel != null ? project.BookModel.CompletedAt.ToString("dd/MMM/yyyy") : "",
                        StartedAt = project.BookModel != null ? project.BookModel.StartedAt.ToString("dd/MMM/yyyy") : "",
                        EndedAt = project.BookModel != null ? project.BookModel.EndedAt.ToString("dd/MMM/yyyy") : "",
                    }
                };
                return projects;
            }
            return null;
        }
       
    }
}