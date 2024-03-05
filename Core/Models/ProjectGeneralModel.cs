using idflApp.Core.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace idflApp.Core.Models
{
    public class ProjectGeneralModel:BaseInterface
    {
        public Guid ProjectId { get; set; }
        public ProjectModel? ProjectModel { get; set; }
        public int ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public int? ClientNumber { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsRushCertificate { get; set; }
        public string? DeniedCertificationDescription { get; set; }
        public string? BannedCertificationDescription { get; set; }

    }
}
