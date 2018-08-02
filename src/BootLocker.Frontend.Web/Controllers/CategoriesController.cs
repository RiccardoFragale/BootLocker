using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BootLocker.Backend.Core.Features;
using BootLocker.Frontend.Common.Entities;
using BootLocker.Frontend.Web.Models;

namespace BootLocker.Frontend.Web.Controllers
{
    public class CategoriesController : Controller
    {
        public ActionResult Index()
        {
            var summaryFeature = new CategoriesSummaryFeature();
            IEnumerable<ElementCategory> featureResult = summaryFeature.Execute();

            VmElementCategoriesSummary model = new VmElementCategoriesSummary
            {
                ElementCategories = featureResult.ToList()
            };

            return View(model);
        }
    }
}