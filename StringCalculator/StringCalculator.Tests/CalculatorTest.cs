using NUnit.Framework;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        private ICalculator _calculator;
        [SetUp]
        public void Init()
        {
            _calculator = new Calculator();
        }
        [Test]
        public void CanInstantiateClass()
        {
            Assert.That(_calculator,Is.Not.Null);
        }

        [Test]
        public void GivenAnEmptyStringReturnZero()
        {
            var result = _calculator.Add("");
            Assert.That(result,Is.EqualTo(0));
        }

        [TestCase("1",1)]
        [TestCase("2",2)]
        [TestCase("3",3)]
        public void GivenANumberReturnsValue(string input,int expected)
        {
            var result = _calculator.Add(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("1,2",3)]
        [TestCase("2,2",4)]
        [TestCase("3,2",5)]
        public void GivenACommaDelimeterNumberReturnsValue(string input,int expected)
        {
            var result = _calculator.Add(input);
            Assert.That(result,Is.EqualTo(expected));
        }

        [TestCase("1\n2,3", 6)]
        public void GivenANumberSeparatedByCommaDelimeter(string input,int expected)
        {
            var result = _calculator.Add(input);
            Assert.That(result,Is.EqualTo(expected));
        }
    }
}