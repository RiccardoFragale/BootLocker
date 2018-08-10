using BootLocker.Backend.Core.Features;
using BootLocker.Frontend.Common.Entities;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace BootLocker.Backend.Api.Controllers
{
    public class ElementCategoriesController : ApiController
    {
        // GET api/elementCategories
        public IEnumerable<ElementCategory> Get()
        {
            var summaryFeature = new CategoriesSummaryFeature();
            IEnumerable<ElementCategory> featureResult = summaryFeature.Execute();

            return featureResult;
        }

        // POST api/elementCategories
        [HttpPost]
        public bool Post(ElementCategory value)
        {
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();

            var feature = new CategoryCreateFeature();
            return feature.Execute(value);
        }
    }
}
