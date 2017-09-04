using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Singleton.UnitTest
{
    /// <summary>
    /// Summary description for TelerikVSUnitTest1
    /// </summary>
    [TestClass]
    public class VS_UnitTest
    {
        [TestMethod]
        public void isSingletonQuickProp()
        {
            SingletonThinking s = SingletonThinking.GetNewInstanceQuickProp;
            SingletonThinking s2 = SingletonThinking.GetNewInstanceQuickProp;

            Assert.AreSame(s,s2);
        }
    }
}
