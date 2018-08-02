using BootLocker.Frontend.Common.Entities;
using System.Collections.Generic;

namespace BootLocker.Backend.Core.Features
{
    public interface ICategoriesSummaryFeature
    {
        IEnumerable<ElementCategory> Execute();
    }
}