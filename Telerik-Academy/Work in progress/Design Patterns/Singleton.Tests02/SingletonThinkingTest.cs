// <copyright file="SingletonThinkingTest.cs" company="Microsoft">Copyright © Microsoft 2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace Singleton.Tests
{
    /// <summary>This class contains parameterized unit tests for SingletonThinking</summary>
    [PexClass(typeof(SingletonThinking))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class SingletonThinkingTest
    {
        /// <summary>Test stub for get_GetNewInstance()</summary>
        [PexMethod]
        internal SingletonThinking GetNewInstanceGetTest()
        {
            SingletonThinking result = SingletonThinking.GetNewInstance;
            return result;
            // TODO: add assertions to method SingletonThinkingTest.GetNewInstanceGetTest()
        }

        /// <summary>Test stub for get_GetNewInstanceQuickProp()</summary>
        [PexMethod]
        internal SingletonThinking GetNewInstanceQuickPropGetTest()
        {
            SingletonThinking result = SingletonThinking.GetNewInstanceQuickProp;
            return result;
            // TODO: add assertions to method SingletonThinkingTest.GetNewInstanceQuickPropGetTest()
        }
    }
}
