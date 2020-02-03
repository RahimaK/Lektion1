using NUnit.Framework;
using Lektion1;


namespace CalculatorTest
{
    [TestFixture]
    public class Tests
    {
        private Calculator c;
        [SetUp]
        public void Setup()
        {

             c = new Calculator();

        }

        [TestCase(4.2,8.1,12.3)] // her indskrives de to testvariable a og b og det endelige resultat
        [TestCase(7.5, 9.1, 16.6)]
        [TestCase(-1.1, 0.1, -1)]
        public void Test_SumAfNumbers(double a, double b, double result)
        {
            Assert.That(c.Add(a,b), Is.EqualTo(result));
        }


        [TestCase(6, 2, 4)] 
        [TestCase(7, 3, 4)]
        [TestCase(10, 5, 5)]
        public void Test_subtractAfNumbers(double a, double b, double result)
        {
            Assert.That(c.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(1, 1, 1)]
        [TestCase(2, 5, 10)]
        [TestCase(10, 2, 20)]
        public void Test_multiplyAfNumbers(double a, double b, double result)
        {
            Assert.That(c.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(5, 1, 5)]
        [TestCase(1, 1, 1)]
        [TestCase(10, 1, 10)]
        public void Test_powerAfNumbers(double a, double b, double result)
        {
            Assert.That(c.Power(a, b), Is.EqualTo(result));
        }

    }
}