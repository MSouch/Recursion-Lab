using System;

class Program
{
    static void Main(string[] args)
    {
        // Addition
        Console.WriteLine("Addition");
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number m: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine(SumFromNToM(n, m));

        // Division
        Console.WriteLine("Division");
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Total number of divisions: {CountDivisionsByTwo(number)}");
    }

    // Method to calculate the sum of all numbers from n to m recursively
    static int SumFromNToM(int n, int m)
    {
        if (n > m) return 0;
        return n + SumFromNToM(n + 1, m);
    }

    // Method to count how many times a number can be evenly divided by 2
    static int CountDivisionsByTwo(int number)
    {
        int count = 0;
        while (number % 2 == 0 && number > 0)
        {
            number /= 2;
            count++;
        }
        return count;
    }
}