using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            int answer;

            Console.WriteLine("Enter the first number.");
            firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number.");
            secondNum = int.Parse(Console.ReadLine());
            answer = firstNum + secondNum;
            Console.WriteLine("The answer of " + firstNum + " + " + secondNum + " is " + answer + ".");
        }
    }
}
