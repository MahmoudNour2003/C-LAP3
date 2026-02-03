using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Calculator
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

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division by zero is not allowed!");

            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            try
            {
                Console.Write("Enter first number: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double y = double.Parse(Console.ReadLine());

                double result = calc.Divide(x, y);
                Console.WriteLine("Result = " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number format!");
            }
            catch (Exception ex)   
            {
                Console.WriteLine("Unknown error!");
            }
        }

    }
}
