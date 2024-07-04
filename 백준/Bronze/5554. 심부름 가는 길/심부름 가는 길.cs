using System;

class Q5554
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int sum = A + B + C + D;
        
        Console.WriteLine(sum / 60);
        Console.WriteLine(sum % 60);
    }
}