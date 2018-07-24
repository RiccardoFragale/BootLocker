using BootLocker.BackendCore.Features;
using NUnit.Framework;

namespace BootLocker.Testing.Behaviours
{
    [TestFixture]
    public class SampleBehavioursTests
    {
        [Test]
        public void SampleFeatureShouldReturnTrueWhenValidInput()
        {
            var sampleFeature = new SampleFeature();
            var result = sampleFeature.Execute();

            Assert.IsTrue(result);
        }
    }
}
