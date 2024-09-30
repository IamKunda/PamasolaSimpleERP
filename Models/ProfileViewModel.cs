using System.ComponentModel.DataAnnotations;

namespace PamasolaSimpleERP.ViewModels
{
    public class ProfileViewModel
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? UserName { get; set; }

        // You can extend this with other profile information like FirstName, LastName, etc.
    }
}
