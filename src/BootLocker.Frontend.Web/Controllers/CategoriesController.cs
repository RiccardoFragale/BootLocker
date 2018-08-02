using System;
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(VmElementCategoryCreate model)
        {
            if (ModelState.IsValid)
            {
                throw new NotImplementedException();
            }

            return View();
        }
    }
}