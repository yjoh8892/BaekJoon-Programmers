using System;

class Q2440
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j <= N; j++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }
}