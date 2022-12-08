using CSharpCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1Calculator
{
    [TestClass]
    internal class CosTests
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
        public void Cos_Positive_Success()
        {
            var input = 60;
            var expectedValue = 0.5;

            var realValue = _sut.Cos(input);

            Assert.AreEqual(expectedValue, realValue);
        }
    }
}
