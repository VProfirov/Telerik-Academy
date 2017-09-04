using System;
using NUnit.Framework;

namespace Singleton.UnitTest
{
    [TestFixture]
    class UnitTest_NUnit
    {
        [Test]
        public static void IsSingleton()
        {
            var s = SingletonThinking.GetNewInstance;
            var s2 = SingletonThinking.GetNewInstance;
            Assert.AreSame(s2,s);
        }
    }
}
