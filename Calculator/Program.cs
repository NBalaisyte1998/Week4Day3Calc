using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Calculator
    {
        public double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public int Minus(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
    }

}
