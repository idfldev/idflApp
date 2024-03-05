using System.Text.Json.Serialization;
using idflApp.Core.Models.Interfaces;

namespace Core.Models.Intefaces
{
    public class AccountModel : BaseInterface
    {
        public string AccountName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }
        public string? Ward { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? Dob { get; set; }
    }
}