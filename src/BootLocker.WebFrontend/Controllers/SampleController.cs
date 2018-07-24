using System.Web.Mvc;
using BootLocker.BackendCore.Features;

namespace BootLocker.WebFrontend.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SampleAction()
        {
            var cleaningFeature = new SampleFeature();
            var isSuccess = cleaningFeature.Execute();

            return RedirectToAction("Ready", new { isSuccess });
        }

        public ActionResult Ready(bool isSuccess)
        {
            return View(isSuccess);
        }
    }
}