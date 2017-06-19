using System;

namespace Merge_Sort
{
    class Program
    {
        static int[] a;
        static void Main(string[] args)
        {
            System.Console.Write("Enter the size of the array: ");
            if(int.TryParse(Console.ReadLine(), out int n))
            {
                a = new int[n];
                System.Console.WriteLine("Enter the elements of the array: ");
                for (int i = 0; i < n; i++)
                {
                    if(int.TryParse(Console.ReadLine(), out int value))
                    {
                        a[i] = value;
                    }
                }
                MergeSort(a);
                System.Console.WriteLine("Sorted array is: ");
                foreach (var item in a)
                {
                    System.Console.WriteLine(item);
                }
            }
        }

        static void MergeSort(int[] a)
        {
            int[] b = new int[a.Length];
            RecursiveMergeSort(b, 0, b.Length - 1);
        }

        static void RecursiveMergeSort(int[] b, int l, int h)
        {
            if(l == h)
                return;
            else
            {
                int mid = (l + h) / 2;
                RecursiveMergeSort(b, l, mid);
                RecursiveMergeSort(b, mid + 1, h);
                Merge(b, l, mid + 1, h);
            }
        }

        static void Merge(int[] b, int l, int mid, int h)
        {
            int j = 0;
            int lowerBound = l;
            int n = h - lowerBound + 1;
            int m = mid - 1;

            while(l <= m && mid <= h)
            {
                if(a[l] < a[mid])
                    b[j++] = a[l++];
                else
                    b[j++] = a[mid++];
            }

            while(l <= m)
                b[j++] = a[l++];
            
            while(mid <= h)
                b[j++] = a[mid++];

            for (int i = 0; i < n; i++)
            {
                a[lowerBound + i] = b[i];
            }
        }

        
    }
}
