
using BootLocker.Frontend.Common;
using BootLocker.Frontend.Common.Entities;

namespace BootLocker.Backend.Core.Features
{
    public class CategoryCreateFeature : ICategoryCreateFeature
    {
        public bool Execute(ElementCategory elementCategory)
        {
            var container = new AppContext();
            
            return true;
        }
    }
}