using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }



        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
            return dividend / divisor;
        }
    }
}
