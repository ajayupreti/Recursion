using System;

namespace Anagrams
{
    class Program
    {
        static int size;
        static int count;
        static char[] word = new char[100];
        static void Main(string[] args)
        {
            System.Console.Write("Enter a word: ");
            string input = Console.ReadLine().Trim();
            word = input.ToCharArray();
            count = 0;
            size = input.Length;
            DoAnagram(size);
        }

        static void DoAnagram(int newSize)
        {
            if(newSize == 1)
                return;
            for (int i = 0; i < newSize; i++)
            {
                DoAnagram(newSize - 1);
                if(newSize == 2)
                    DisplayWord();
                Rotate(newSize);
            }
        }

        private static void Rotate(int newSize)
        {
            int j;
            int position = size - newSize;
            char temp = word[position];
            for(j=position+1; j<size; j++)
            {
                word[j-1] = word[j];
            }
            word[j-1] = temp;
        }

        static void DisplayWord()
        {
            if(count < 99)
                System.Console.Write(" ");
            if(count < 9)
                System.Console.Write(" ");
            System.Console.Write(++count + " ");
            for (int i = 0; i < size; i++)
            {
                System.Console.Write(word[i]);
            }
            System.Console.Write("      ");            
            if(count % 6 == 0)
                System.Console.WriteLine("");
        }
    }    
}
