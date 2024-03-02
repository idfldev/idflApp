using System.ComponentModel.DataAnnotations;

namespace idflApp.Core.Models.Interfaces
{
    public class ContentModel : BaseInterface
    {
        [Required, MinLength(5), MaxLength(100)]
        public string? Name { get; set; }
        [MinLength(5)]
        public string? Description { get; set; }
    }
}