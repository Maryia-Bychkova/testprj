using CSharpCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1Calculator
{
    [TestClass]
    internal class PowTests
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
        public void Pow_Positive_Success()
        {
            var input1 = 7;
            var input2 = 2;
            var expectedValue = 49;

            var realValue = _sut.Pow(input1, input2);

            Assert.AreEqual(expectedValue, realValue);
        }
    }
}
