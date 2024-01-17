using Microsoft.AspNetCore.Components;

namespace CourseBlazorApp.Pages.EventCallbackSample
{
    public partial class Child
    {
        [Parameter]
        public EventCallback<int> OnRandomGenerated { get; set; }


        private int Number { get; set; }

        public void OnClick()
        {
            Number = Random.Shared.Next();
            OnRandomGenerated.InvokeAsync(Number);
        }
    }
}