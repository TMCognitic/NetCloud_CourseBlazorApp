using CourseBlazorApp.Models.Forms;

namespace CourseBlazorApp.Pages.FormSample
{
    public partial class FormSample
    {
        private string? Content { get; set; }

        private CreateContactForm Form { get; set; } = default!;

        protected override void OnInitialized()
        {
            Form = new CreateContactForm(); //résultat de la récupération de données externe
        }

        public void Save()
        {
            Content = "Saved!!";
        }
    }
}
