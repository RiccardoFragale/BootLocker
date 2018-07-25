using System.Web.Mvc;
using BootLocker.Backend.Core.Features;
using BootLocker.Frontend.Web.Models;

namespace BootLocker.Frontend.Web.Controllers
{
    public class CategoriesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(VmElementCategoriesSummary model)
        {
            var sampleFeature = new SampleFeature();
            var isSuccess = sampleFeature.Execute();

            return RedirectToAction("Ready", new { isSuccess });
        }

        public ActionResult Ready(bool isSuccess)
        {
            return View(isSuccess);
        }
    }
}