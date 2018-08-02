using BootLocker.Frontend.Common.Entities;

namespace BootLocker.Backend.Core.Features
{
    public interface ICategoryCreateFeature
    {
        bool Execute(ElementCategory elementCategory);
    }
}