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

        public double Factorial(double a)
        {
            double fact=1;
            if (a == 0)
            {
                Console.WriteLine("0 factorial is equal to 1");
                return 1;
            }

            for (int i = 1; i <= a; i++)
            {
                fact = fact*i;
                
            }

            return fact;
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

        public double Modulus(double dividend, double divisor)
        {

            if (divisor <= 0)
            {
                Console.WriteLine("Cannot divide by zero, and therefor not find modulus.");
                return 0;
            }

            double d = dividend % divisor;
            return d;
        }

    }
}
