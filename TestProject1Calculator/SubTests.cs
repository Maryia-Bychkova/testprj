using CSharpCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1Calculator
{
    [TestClass]
    internal class SubTests
    {
        private Calculator _sut;

        [TestInitialize]
        public void SetUp()
        {
            _sut = new Calculator();
        }

        [TestCleanup]
        public void CleanUp()
        {
        }

        [TestMethod]
        public void Sub_Positive_Success()
        {
            var input1 = 6;
            var input2 = 1;
            var expectedValue = 5;

            var realValue = sut.Sub(input1, input2);

            Assert.AreEqual(expectedValue, realValue);
        }
    }
}
