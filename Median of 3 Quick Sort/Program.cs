using System;

namespace Median_of_3_Quick_Sort
{
    class Program
    {
        static int[] items;
        static void Main(string[] args)
        {
            System.Console.Write("Enter the number of items: ");
            if(int.TryParse(Console.ReadLine().ToString(), out int n))
            {
                items = new int[n];
                System.Console.WriteLine("Enter the items: ");
                for (int i = 0; i < n; i++)
                {
                    if(int.TryParse(Console.ReadLine(), out int item))
                    {
                        items[i] = item;
                    }
                }
                QuickSort(0, n - 1);
                System.Console.WriteLine("The sorted array is: ");
                for (int i = 0; i < n; i++)
                {
                    System.Console.WriteLine(items[i]);
                }
            }
            else{
                return;
            }
        }

        static void QuickSort(int left, int right)
        {
            int size = right - left + 1;
            if(size < 10)
                InsertionSort(left, right);
            else
            {
                int pivot = MedianOf3(left, right);
                int partitionElement = Partition(left, right, pivot);
                QuickSort(left, partitionElement - 1);
                QuickSort(partitionElement + 1, right);
            }
        }

        static void InsertionSort(int left, int right)
        {
            int j;
            for(int i = left + 1; i <= right; i++)
            {
                int temp = items[i];
                j = i;
                while(j > left && items[j - 1] >= temp)
                {
                    items[j] = items[j - 1];
                    --j;
                }
                items[j] = temp;
            }
        }

        static int Partition(int left, int right, int pivot)
        {
            int i = left;
            int j = right - 1;

            while(true)
            {
                while(items[++i] < pivot)
                    ;
                while(items[--j] > pivot)
                    ;
                if(i >= j)
                    break;
                else
                    Swap(i, j);
            }
            Swap(i, right - 1);
            return i;
        }

        static int MedianOf3(int left, int right)
        {
            int center = (left + right) / 2;

            if(items[left] > items[center])
                Swap(left, center);
            if(items[left] > items[right])
                Swap(left, right);
            if(items[center] > items[right])
                Swap(center, right);

            //Move the pivot to the end of the array
            Swap(center, right - 1);
            return items[right - 1];
        }

        static void Swap(int i, int j)
        {
            int temp;
            temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }
    }
}
