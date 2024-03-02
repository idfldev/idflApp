using System.ComponentModel.DataAnnotations;

namespace idflApp.Core.Dtos
{
    public class AuthenticateRequestDto
    
    {
        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}