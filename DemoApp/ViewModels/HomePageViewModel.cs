using Our.Umbraco.Ditto;

namespace DemoApp.ViewModels
{
    public class HomePageViewModel
    {
        [UmbracoProperty("content_title", Order = 0)]
        [AltUmbracoProperty("seo_metaTitle", Order = 1)]
        [AltUmbracoProperty("Name", Order = 2)]
        public string Title { get; set; }
    }
}