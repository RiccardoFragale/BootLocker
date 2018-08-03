using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using BootLocker.Backend.Core.Features;
using BootLocker.Frontend.Common.Entities;
using BootLocker.Frontend.Web.Models;

namespace BootLocker.Frontend.Web.Controllers
{
    public class CategoriesController : Controller
    {
        static HttpClient client = new HttpClient {
            BaseAddress = new Uri("http://localhost:50241/")
        };

        public async Task<ActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync(
                "api/elementCategories");
            response.EnsureSuccessStatusCode();

            var featureResult = await response.Content.ReadAsAsync<List<ElementCategory>>();

            VmElementCategoriesSummary model = new VmElementCategoriesSummary
            {
                ElementCategories = featureResult
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
                var feature = new CategoryCreateFeature();
                feature.Execute(model.ElementCategory);
            }

            return View();
        }
    }
}