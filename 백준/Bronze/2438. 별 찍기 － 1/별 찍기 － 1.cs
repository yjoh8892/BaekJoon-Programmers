using System;

class Q2438
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}