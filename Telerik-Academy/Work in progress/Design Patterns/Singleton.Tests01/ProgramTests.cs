// <copyright file="ProgramTest.cs" company="Microsoft">Copyright © Microsoft 2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using Singleton;

namespace Singleton.Tests
{
    /// <summary>This class contains parameterized unit tests for Program</summary>
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class ProgramTests
    {
        /// <summary>Test stub for Main(String[])</summary>
        [PexMethod]
        internal void MainTest(string[] args)
        {
            Program.Main(args);
            // TODO: add assertions to method ProgramTest.MainTest(String[])
        }
    }
}
