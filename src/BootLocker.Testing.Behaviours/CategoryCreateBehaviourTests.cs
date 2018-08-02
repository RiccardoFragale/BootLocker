using BootLocker.Backend.Core.Features;
using BootLocker.Frontend.Common.Entities;
using NUnit.Framework;

namespace BootLocker.Testing.Behaviours
{
    [TestFixture]
    public class CategoryCreateBehaviourTests
    {
        [Test]
        public void CreateFeatureShouldReturnTrueWhenValidInput()
        {
            var createFeature = new CreateFeature();
            var result = createFeature.Execute(new ElementCategory());

            Assert.IsTrue(result);
        }
    }
}
