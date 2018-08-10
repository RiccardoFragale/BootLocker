using BootLocker.Backend.Core.Features;
using BootLocker.Frontend.Common.Entities;
using NUnit.Framework;

namespace BootLocker.Testing.Behaviours
{
    [TestFixture]
    public class CategoryCreateBehaviourTests
    {
        [Test]
        public void CategoryCreateFeatureShouldReturnTrueWhenValidInput()
        {
            var createFeature = new CategoryCreateFeature();

            ElementCategory elementCategory = new ElementCategory
            {
                Name = "testCategory",
                Description = "test category"
            };

            var result = createFeature.Execute(elementCategory);

            Assert.IsTrue(result.Id > 0);
        }
    }
}
