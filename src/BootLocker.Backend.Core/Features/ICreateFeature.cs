using BootLocker.Frontend.Common.Entities;

namespace BootLocker.Backend.Core.Features
{
    public interface ICreateFeature
    {
        bool Execute(ElementCategory elementCategory);
    }
}