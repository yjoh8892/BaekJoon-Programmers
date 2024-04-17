using System;

class Q24267
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        
        Console.WriteLine(n * (n - 1) * (n - 2) / (3 * 2));
        Console.WriteLine(3);
    }
}