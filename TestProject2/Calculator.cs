using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    using System;

    public class Calculator
    {
        // Adds two numbers together and returns the result.
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Subtracts the second number from the first and returns the result.
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiplies two numbers together and returns the result.
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Divides the first number by the second and returns the result.
        // Throws DivideByZeroException if the divisor is zero.
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");

            return a / b;
        }
    }
}

