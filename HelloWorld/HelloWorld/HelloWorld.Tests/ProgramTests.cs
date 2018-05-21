using System;
using System.Collections.Generic;
using System.Text;
using HelloWorld.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World!", Program.CreateMessage("Hello World!"));
        }
    }
}
