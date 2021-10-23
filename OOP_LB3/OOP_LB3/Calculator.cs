using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LB3
{
    public class Calculator
    {
        double x, y;

        public Calculator(double X, double Y, char operation)
        {
            x = X;
            y = Y;

            if (operation == '+') Addition();
            else if (operation == '-') Deduction();
            else if (operation == '*') Multiplication();
        }

        public void Addition()
        {
            Console.WriteLine(x + y);
        }
        public void Deduction()
        {
            Console.WriteLine(x - y);
        }
        public void Multiplication()
        {
            Console.WriteLine(x * y);
        }
    }
}
