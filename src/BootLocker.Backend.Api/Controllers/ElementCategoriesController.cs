using BootLocker.Backend.Core.Features;
using BootLocker.Frontend.Common.Entities;
using System.Collections.Generic;
using System.Web.Http;

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
    }
}
