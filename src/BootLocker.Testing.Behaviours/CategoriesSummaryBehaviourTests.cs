using BootLocker.Backend.Core.Features;
using NUnit.Framework;
using System.Linq;

namespace BootLocker.Testing.Behaviours
{
    [TestFixture]
    public class CategoriesSummaryBehaviourTests
    {
        [Test]
        public void CategorySummaryFeatureShouldReturnListOfCategories()
        {
            var summaryFeature = new CategoriesSummaryFeature();
            var result = summaryFeature.Execute();

            Assert.IsTrue(result.Any());
        }
    }
}
