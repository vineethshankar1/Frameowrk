
using NUnit.Framework;

namespace AnythingCanBeDone.specs.ui
{
    public class UiBase
    {
        [TestFixtureSetUp]
        public void Init()
        {

        }

        [SetUp]
        public void Setup()
        {

        }

        [TearDown]
        public void Teardown()
        {

        }

        [TestFixtureTearDown]
        public void Cleanup()
        { /* ... */}
    }
}
