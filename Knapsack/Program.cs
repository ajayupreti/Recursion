using System;
using System.Collections.Generic;

namespace Knapsack
{
    class Program
    {
        static int[] items;
        static List<int> itemsInKnapsack;
        static void Main(string[] args)
        {
            System.Console.Write("Enter the number of items: ");
            if(int.TryParse(Console.ReadLine(), out int n))            
            {
                items = new int[n];                
                System.Console.WriteLine("Enter the items: ");
                for (int i = 0; i < n; i++)
                {
                    if(int.TryParse(Console.ReadLine(), out int item))
                        items[i] = item;
                }                
                System.Console.WriteLine("Enter the weight of knapsack: ");
                if(int.TryParse(Console.ReadLine(), out int weight))            
                {
                    itemsInKnapsack = new List<int>();
                    KP(weight);
                    Display();
                }
            }
        }

        static int GetCurrentKnapsackWeight()
        {
            int sum = 0;
            foreach (var item in itemsInKnapsack)
            {
                sum += item;
            }
            return sum;
        }

        static void KP(int weight)
        {
            for (int i = 0; i < items.Length; i++)
            {
                RecKnapsack(weight, i);
                if(GetCurrentKnapsackWeight() == weight)
                {
                    System.Console.WriteLine("Success!!");
                    break;
                }
                else itemsInKnapsack.Clear();
            }
        }

        static void RecKnapsack(int weight, int i)
        {
            if(i > items.Length - 1 || (items[i] > weight && i == items.Length - 1))
                return;
            if(items[i] <= weight)
            {
                itemsInKnapsack.Add(items[i]);
                RecKnapsack(weight - items[i], i + 1);       
            }
            else
            {
                RecKnapsack(weight, i + 1);
            }            
        }

        static void Display()
        {
            foreach (var item in itemsInKnapsack)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
