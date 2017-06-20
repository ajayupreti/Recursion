using System;

namespace Binary_Trees
{
    class Program
    {        
        static string[] tree;
        static void Main(string[] args)
        {
            bool isValid = false;
            while(!isValid)
            {
                System.Console.Write("Enter the number of levels: ");                
                if(int.TryParse(Console.ReadLine(), out int n) && n > 0)
                {               
                    int chars = (int)(Math.Pow(2, n - 1));
                    tree = new string[n];
                    for(int i = 0; i < tree.Length; i++) tree[i] = string.Empty;
                    BinaryTrees(0, chars -1, 0);
                    DisplayTree();
                    isValid = true;
                }
            }
        }

        static void BinaryTrees(int left, int right, int row)
        {                                    

            int mid = (right + left) / 2;       
            if(left > right || row > tree.Length - 1 || (left == right && row > tree.Length - 1)) return;
            if(left == right) mid = 0;
            for (int i = left; i <= right; i++)
            {
                if(i == mid || (mid == 0 && row == tree.Length - 1))
                    tree[row] += "X";
                else
                    tree[row] += "-";
            }
            BinaryTrees(left, mid, row + 1);
            BinaryTrees(mid + 1, right, row + 1);
        }

        static void DisplayTree()
        {
            foreach (var item in tree)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
