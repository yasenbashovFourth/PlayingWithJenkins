using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.ConsoleApp;

namespace HelloWorld.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World!", Program.CreateMessage());
        }
    }
}
