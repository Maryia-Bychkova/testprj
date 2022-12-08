using CSharpCalculator;


namespace TestProject1
{
    public class Tests
    {
        private Calculator _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Calculator();
        }

        [Test]
        public void Multiply_Positive_Success()
        {
            var input1 = 7;
            var input2 = 2;
            var expectedValue = 14;

            _sut = new Calculator();

            var realValue = _sut.Multiply(input1, input2);

            Assert.IsTrue(expectedValue == realValue);
        }

        [Test]
        public void Abs_Positive_Success()
        {
            var input = -4;
            var expectedValue = 4;

            _sut = new Calculator();

            var realValue = _sut.Abs(input);

            Assert.IsTrue(expectedValue == realValue);
        }


        [TestCase(Math.PI / 2, 1D)]
        [TestCase(-Math.PI / 2, -1D)]
        public void Sin_Positive_Success(double rad, double expectedRes)
        {
            Assert.IsTrue(_sut.Sin(rad) == expectedRes);
        }

        [TestCase(1, true)]
        [TestCase(0, false)]
        [TestCase(-1, false)]

        public void IsPositive(int input, bool expected)
        {
            Assert.IsTrue(_sut.isPositive(input) == expected);
        }

        [TestCase(1, false)]
        [TestCase(0, false)]
        [TestCase(-1, true)]

        public void IsNegative(int input, bool expected)
        {
            Assert.IsTrue(_sut.isNegative(input) == expected);
        }

    }
}



