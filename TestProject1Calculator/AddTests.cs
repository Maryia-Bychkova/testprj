using CSharpCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1Calculator
{
    [TestClass]
    internal class AddTests
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
        public void Add_Positive_Success()
        {
            var input1 = 2;
            var input2 = 3;
            var expectedValue = 5;

            _sut = new Calculator();

            var realValue = _sut.Add(input1, input2);

            Assert.AreEqual(expectedValue, realValue);
        }
    }
}
