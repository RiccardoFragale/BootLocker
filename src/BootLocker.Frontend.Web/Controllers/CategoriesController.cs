using System.Web.Mvc;
using BootLocker.Backend.Core.Features;
using BootLocker.Frontend.Common.Entities;

namespace BootLocker.Frontend.Web.Controllers
{
    public class CategoriesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(ElementCategory elementCategory)
        {
            var sampleFeature = new CreateFeature();
            var isSuccess = sampleFeature.Execute(elementCategory);

            return RedirectToAction("Ready", new { isSuccess });
        }

        public ActionResult Ready(bool isSuccess)
        {
            return View(isSuccess);
        }
    }
}