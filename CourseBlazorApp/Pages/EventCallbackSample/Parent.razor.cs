namespace CourseBlazorApp.Pages.EventCallbackSample
{
    public partial class Parent
    {
        private List<int> Items { get; set; } = new List<int>();


        private void OnNewNumber(int number)
        {
            Items.Add(number);
        }
    }
}
