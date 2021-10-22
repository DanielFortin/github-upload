using System;

namespace lengthandwidth
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Price = 3;

            int length;
            int width;
            int area;
            int cost;

            Console.WriteLine("Enter the length of your room.");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of your room.");
            width = int.Parse(Console.ReadLine());
            area = length * width;
            cost = area * Price;
            Console.WriteLine("The price of your carpeting will be " + cost + ".");
        }
    }
}
