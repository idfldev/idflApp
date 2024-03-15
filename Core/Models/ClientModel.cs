using System.Text.Json.Serialization;
using Core.Models.Intefaces;
using idflApp.Constants;
using idflApp.Core.Models.Interfaces;

namespace idflApp.Core.Models
{
    public class ClientModel : BaseInterface
    {
        public string? DisplayName { get; set; }
        public int ClientCode { get; set; }
        public ClientRole ClientRole { get; set; }
        public bool IsThirdParty { get; set; }
        [JsonIgnore]
        public required string Password { get; set; }
        public bool IsVerified { get; set; }
        public bool IsActive { get; set; }
        public string? Status { get; set; }
        public List<ProjectModel> ProjectModels { get; set; }
        public List<ClientInfomationModel> ClientInfomationModels { get; set; }
        public List<AccountVerifyModel> AccountVerifyModels { get; set; }
    }
}