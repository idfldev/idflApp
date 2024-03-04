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
        public bool OEKO { get; set; }
        public bool SCS { get; set; }
        public bool BSCI { get; set; }
        public bool SA8000 { get; set; }
        public bool FEM { get; set; }
        public bool FSLM { get; set; }
        public bool BRM { get; set; }
        public bool WRAP { get; set; }
        public bool ChemicalInputGOTS { get; set; }
        public bool ChemicalsAreUsedGOTS { get; set; }
        public bool ChemicalInputGRS { get; set; }
        public bool ChemicalsAreUsedGRS { get; set; }
        public bool CertificationCompliance { get; set; }
        public string? DeniedCertificationDescription { get; set; }
        public string? BannedCertificationDescription { get; set; }

    }
}
