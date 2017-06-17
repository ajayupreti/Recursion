using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Fact f = new Fact();
            Console.WriteLine(f.Factorial(5));
        }
    }

    class Fact
    {
        public int Factorial(int n)
        {
            if(n == 1)
                return 1;
            return n * Factorial(n-1);
        }
    }
}
