using CourseBlazorApp.Infrastructure;
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
        //[Range(typeof(DateTime), "1/1/2024", "3/4/2024",
        //ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [DateRange]
        public DateTime Anniversaire { get; set; } = DateTime.Now;
    }
}
