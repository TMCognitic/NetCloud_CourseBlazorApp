using System.ComponentModel.DataAnnotations;

namespace CourseBlazorApp.Models.Forms
{
    public class CreateContactForm
    {
        [Required]
        public string Nom { get; set; } = default!;
        [Required]
        public string Prenom { get; set; } = default!;
        [Required]
        public DateTime Anniversaire { get; set; } = DateTime.Now;
    }
}
