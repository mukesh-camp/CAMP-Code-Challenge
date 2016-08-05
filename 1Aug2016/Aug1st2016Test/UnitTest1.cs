using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aug1st2016;

namespace Aug1st2016Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var inputVals= new int[5] { 1,2,3,4,5};
            var result = ProgramAug1st2016.CheckTotal(inputVals);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var inputVals = new int[4] { 11, 20, 8, 31 };
            var result = ProgramAug1st2016.CheckTotal(inputVals);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var inputVals = new int[7] { 1, 2, 3, 3, 0, 9, 9 };
            var result = ProgramAug1st2016.CheckTotal(inputVals);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var inputVals = new int[5] { 1, 2, 3, 4, 5 };
            var result = ProgramAug1st2016.CheckTotal(inputVals);
            Assert.IsFalse(result);
        }
    }
}
