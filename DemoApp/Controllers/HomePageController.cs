using System.Web.Http;
using System.Web.Mvc;
using DemoApp.ComponentModel.Processors;
using DemoApp.ViewModels;
using Our.Umbraco.Ditto;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace DemoApp.Controllers
{
    public class HomePageController : RenderMvcController
    {
        public ActionResult HomePage(RenderModel model, [FromUri] int offset = 0)
        {
            var contexts = new[]{
                new AddNumberProcessorContext() {
                    Number = offset
                }
            };


            return View(model.As<HomePageViewModel>(processorContexts: contexts));
        }

    }
}