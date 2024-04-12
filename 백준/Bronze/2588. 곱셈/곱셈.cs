using System;

class Q2588
{
    static void Main(String[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        
        Console.WriteLine(A * (B % 10));
        Console.WriteLine(A * ((B % 100) / 10));
        Console.WriteLine(A * (B / 100));
        Console.WriteLine(A * B);
    }
}