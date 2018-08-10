
using BootLocker.Frontend.Common;
using BootLocker.Frontend.Common.Entities;
using System;

namespace BootLocker.Backend.Core.Features
{
    public class CategoryCreateFeature : ICategoryCreateFeature
    {
        public ElementCategory Execute(ElementCategory elementCategory)
        {
            var container = new AppContext();
            elementCategory.Id = 1;
            elementCategory.GuId = Guid.NewGuid();

            return elementCategory;
        }
    }
}