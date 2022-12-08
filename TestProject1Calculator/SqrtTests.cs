using CSharpCalculator;


namespace TestProject1Calculator
{
    [TestClass]
    public class SqrtTests
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
        public void Sqrt_Positive_Success()
        {
            var input = 16;
            var expectedValue = 4;

            var realValue = _sut.Sqrt(input);

            Assert.AreEqual(expectedValue, realValue);
        }
        [TestMethod]
        public void Sqrt_Negative_Return_NaN()
        {
            var input = -16;

            var realValue = _sut.Sqrt(input);

            Assert.AreEqual(realValue, double.NaN);

        }

        [TestMethod]
        public void Sqrt_Zero_Return_Zero()
        {
            var input = 0;

            var realValue = _sut.Sqrt(input);

            Assert.AreEqual(realValue, 0D);

        }


        [TestMethod]
        public void Sqrt_Not_Valid_String_Throws_Exception()
        {
            var input = "werwerwerw";

            Assert.ThrowsException<FormatException>(() => _sut.Sqrt(input));

        }





    }
        
}


/*
 * Ќапишите 10 тестовых методов(позитивных и
  негативных), использую NUnit и MSTest
 (в сумме должно получитс€ 20 тестов).
 аждый класс должен тестировать только 
один метод библиотеки.
ѕредуслови€ и постуслови€ тестов должны быть
реализованы с соответствующими аннотаци€ми.
—оздать параметризированные тесты (используйте 
соответсвующие аттрибуты).
*/