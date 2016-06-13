using Our.Umbraco.Ditto;

namespace DemoApp.ViewModels
{
    public class HomePageViewModel
    {
        [UmbracoProperty("content_title")]
        public string Title { get; set; }
    }
}