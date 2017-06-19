using System;

namespace Recursive_Binary_Search
{
    class Program
    {
        static int[] values;
        static void Main(string[] args)
        {
            System.Console.Write("Enter the size of array: ");
            if(int.TryParse(System.Console.ReadLine(), out int n))
            {
                System.Console.WriteLine("Enter the array: ");
                values = new int[n];
                for (int i = 0; i < n; i++)
                {
                    if(int.TryParse(Console.ReadLine(), out int x)){
                        values[i] = x;
                    }   
                }
                Array.Sort(values);
                System.Console.WriteLine("Sorted array is: ");
                for (int i = 0; i < n; i++)
                {
                    System.Console.WriteLine(values[i]);
                }
                System.Console.Write("Enter the key to be searched: ");
                if(int.TryParse(Console.ReadLine(), out int key))
                {
                    System.Console.WriteLine(BinarySearch(key, 0, n - 1));
                }
            }
        }

        static int BinarySearch(int key, int low, int high)
        {
            int mid = (low + high) / 2;

            if(values[mid] == key)
                return mid;
            else if(low > high)
                return -1;
            else
            {
                if(key < values[mid])
                    return BinarySearch(key, low, mid - 1);
                else
                    return BinarySearch(key, mid + 1, high);
            }
        }
    }
}
