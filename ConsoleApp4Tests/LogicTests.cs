using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void GetSumTest1()
        {
            var text = "111+10-30";
            var sum = 91;

            var message = Logic.GetSum(text);

            Assert.AreEqual(sum, message);
        }

        [TestMethod()]
        public void GetSumTest2()
        {
            var text = "111";
            var sum = 111;

            var message = Logic.GetSum(text);

            Assert.AreEqual(sum, message);
        }

        [TestMethod()]
        public void GetSumTest3()
        {
            var text = "1+10-45-10+4";
            var sum = -40;

            var message = Logic.GetSum(text);

            Assert.AreEqual(sum, message);
        }
    }
}