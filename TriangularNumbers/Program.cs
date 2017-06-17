using System;

namespace TriangularNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            Console.WriteLine(t.TriangularNumber(4));
        }
    }

    class Triangle
    {
        public int TriangularNumber(int n)
        {
            if(n == 1)
                return 1;
            return n + TriangularNumber(n-1);
        }
    }
}
