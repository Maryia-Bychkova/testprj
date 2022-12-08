using CSharpCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1Calculator
{
    [TestClass]
    internal class DivTests
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
        public void Divide_Positive_Success()
        {
            var input1 = 10;
            var input2 = 2;

            var expectedValue = 5;

            var realValue = _sut.Divide(input1, input2);

            Assert.AreEqual(expectedValue, realValue);
        }

        [TestMethod]
        public void Divide_By_Zero_Throws_Exception()
        {
            var input1 = 2;
            var input2 = 0;

            Assert.ThrowsException<DivideByZeroException>(() => _sut.Divide(input1, input2));

        }
    }
}
