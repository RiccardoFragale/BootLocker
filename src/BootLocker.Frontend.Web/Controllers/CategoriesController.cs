using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
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
                "api/ElementCategories");
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
        public async Task<ActionResult> Create(VmElementCategoryCreate model)
        {
            if (ModelState.IsValid)
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("api/ElementCategories", model.ElementCategory);
                response.EnsureSuccessStatusCode();

                ElementCategory featureResult = await response.Content.ReadAsAsync<ElementCategory>();

                model = new VmElementCategoryCreate
                {
                    ElementCategory = featureResult
                };
            }

            return View(model);
        }
    }
}