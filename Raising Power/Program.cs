using System;

namespace Raising_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the number: ");
            if(int.TryParse(Console.ReadLine(), out int x))
            {
                System.Console.Write("Enter the power: ");
                if(int.TryParse(Console.ReadLine(), out int y))
                {
                    Console.WriteLine($"{x} raised to the power {y} is {Power(x, y)}");
                }
            }
        }

        static long Power(int x, int y)
        {
            if(y == 1)
                return x;
            long value = Power(x * x, y / 2);
            if(y % 2 == 1)
                return x * value;
            return value;
        }
    }
}
