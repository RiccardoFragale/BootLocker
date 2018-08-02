
using BootLocker.Frontend.Common;
using BootLocker.Frontend.Common.Entities;
using System.Collections.Generic;

namespace BootLocker.Backend.Core.Features
{
    public class CategoriesSummaryFeature : ICategoriesSummaryFeature
    {
        public IEnumerable<ElementCategory> Execute()
        {
            var container = new AppContext();
            
            return container.Categories;
        }
    }
}