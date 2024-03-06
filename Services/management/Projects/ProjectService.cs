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
            var users = _context.User.Select(s=>new UserDto{
                    Id = s.Id,
                    Name = s.AccountName
            }).ToList();
            var projects = _context.Project
                .Include(c => c.UserModel)
                .Include(c => c.StandardModel)
                .Include(c => c.ClientModel)
                .Select(s => new FindProjectDto
                {
                    Id = s.Id,
                    Standard = s.StandardModel!.StandardCode +"-"+ s.StandardModel!.Name,
                    BookId = s.BookId,
                    IdflCode = s.IdflCode,
                    Client = s.ClientModel!.AccountName,
                    IsInitialCertification = s.IsInitialCertification,
                    IsRenewalCertification = s.IsRenewalCertification,
                    IsAnotherCertification = s.IsAnotherCertification,
                    LicenseNo = s.LicenseNo,
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


    }
}