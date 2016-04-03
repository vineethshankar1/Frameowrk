
using AnythingCanBeDone.lib;
using NUnit.Framework;
using System;

namespace AnythingCanBeDone.specs.services
{
    public class ServiceBase
    {
        public Json JsonInstance;

        [TestFixtureSetUp]
        public void Init()
        {
            Console.WriteLine("I'm in Test Fixture Setup");
            JsonInstance = new Json();
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("I'm in Test Setup");
        }

        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("I'm in Test TearDown");
        }

        [TestFixtureTearDown]
        public void Cleanup()
        {
            Console.WriteLine("I'm in Test Fixture TearDown");
        }
    }
}
