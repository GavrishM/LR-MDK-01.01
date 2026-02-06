using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestClassLibrary;

namespace TestModule
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void LogicAndTest(Logic logic)
        {
            bool x = true;
            bool y = true;
            bool expectedResult = true;
            bool actualResult = logic.LogicAnd(x, y);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
