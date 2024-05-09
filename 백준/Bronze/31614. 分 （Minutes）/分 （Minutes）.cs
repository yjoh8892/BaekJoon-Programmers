using System;

class Q31614
{
    static void Main(string[] args)
    {
        int H = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int total = H * 60 + M;
        
        Console.WriteLine(total);
    }
}