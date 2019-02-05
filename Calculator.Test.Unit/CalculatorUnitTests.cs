using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("Troels Jensen")]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        // Using the SetUp feature, saves coding (part of) the Arrange step
        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        // A single test case, with fixed input and expected output
        [Test]
        public void Add_Add2And3_ResultIs5()
        {
            // Act
            var result = _uut.Add(2, 3);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        // The TestCase feature allows reusing test code for diffent input and expected output
        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            // Combining the Act and Assert steps is also possible
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        // For floating point results, exact equal comparison can be tricky
        // Use EqualTo modifier Within
        [Test]
        public void Power_SquareRootHalf_ResultIsWithinPrecision()
        {
            // Raising a number to 1/2 is the same as taking the square root
            double result = _uut.Power(0.5, 0.5);

            Assert.That(result, Is.EqualTo(0.707107).Within(0.0000005));
        }

        [TestCase(9, 3)]
        [TestCase(25, 5)]
        public void Sqrt_SqrtOf(double a, double result)
        {
            Assert.That(_uut.Sqrt(a),Is.EqualTo(result));
        }
        [TestCase(4,2,2)]
        [TestCase(10,5,2)]
        [TestCase(20,2,10)]
        [TestCase(10,4,2.5)]
        public void Divide_DividePositiveNumbers_ResultIsCorrect(double dividend, double divisor, double expectedResult)
        {
            double result = _uut.Divide(dividend, divisor);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Divide_DivideByZero_WritesToConsole()
        {
            double result = _uut.Divide(5, 0);
            Assert.That(0,Is.EqualTo(result));
        }

        [TestCase(10,3628800)]
        [TestCase(5,120)]
        public void Factorial_FactorialOfNumber_ReturnResult(double a, double result)
        {
            Assert.That(_uut.Factorial(a),Is.EqualTo(result));
        }

        [Test]
        public void Factorial_FactorialOfZero_ReturnOne()
        {
            var result = _uut.Factorial(0);

            Assert.That(result,Is.EqualTo(1));
        }

        [TestCase(10, 2, 0)]
        [TestCase(10, 3, 1)]
        [TestCase(176, 155, 21)]
        public void Modulus_ModulusOfDividend_ofDivisor_ReturnResult(double dividend, double divisor, double result)
        {
            Assert.That(_uut.Modulus(dividend,divisor),Is.EqualTo(result));
        }

        [Test]
        public void Modulus_DivideByZero_ReturnZero()
        {
            var result = _uut.Modulus(10, 0);
            Assert.That(result,Is.EqualTo(0));
        }
        
    }
}
