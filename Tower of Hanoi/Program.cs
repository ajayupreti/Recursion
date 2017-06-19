using System;

namespace Tower_of_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the number of disks: ");
            if(int.TryParse(Console.ReadLine(), out int n))
            {
                Tower(n, 'A', 'B', 'C');
            }
        }

        static void Tower(int numberOfDisks, char source, char intermediate, char destination)
        {
            if(numberOfDisks == 1)
                System.Console.WriteLine($"Move Disk 1 from {source} to {destination}");
            else
            {
                Tower(numberOfDisks - 1, source, destination, intermediate);
                System.Console.WriteLine($"Move Disk {numberOfDisks} from {source} to {destination}");
                Tower(numberOfDisks - 1, intermediate, source, destination);
            }
        }
    }
}
