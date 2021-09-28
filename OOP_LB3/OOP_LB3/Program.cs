using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            bool f = false;
            try
            {
                switch (f)
                {
                    case false:
                        {
                            Console.WriteLine("Введите первое число, операцию (+,-,*) и затем второе число:");
                            string readLine = Console.ReadLine();

                            double x = Double.Parse(string.Concat(readLine.TakeWhile(char.IsDigit)));
                            char operation = readLine.First(x => x.Equals('+') || x.Equals('-') || x.Equals('*'));
                            int IndexOperation = readLine.IndexOf(operation);
                            string LineAfterOperation = readLine.Substring(IndexOperation + 1);
                            int IndexNumbersAfterOperation = LineAfterOperation.IndexOfAny(numbers);
                            string NumbersAfterOperation = LineAfterOperation.Substring(IndexNumbersAfterOperation);

                            double y = Double.Parse(string.Concat(NumbersAfterOperation.TakeWhile(char.IsDigit)));
                            Calculator calculator = new Calculator(x, y, operation);
                            goto case false;
                        }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }   
}