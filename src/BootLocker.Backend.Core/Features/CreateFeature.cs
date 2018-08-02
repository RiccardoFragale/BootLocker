
using BootLocker.Frontend.Common;
using BootLocker.Frontend.Common.Entities;

namespace BootLocker.Backend.Core.Features
{
    public class CreateFeature : ICreateFeature
    {
        public bool Execute(ElementCategory elementCategory)
        {
            var container = new AppContext();

            container.Categories.Add(elementCategory);

            return true;
        }
    }
}