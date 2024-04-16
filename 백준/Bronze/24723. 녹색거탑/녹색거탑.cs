using System;

class Q24723
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int Ans = 1;
        
        for (int i = 0; i < N; i++)
        {
            Ans *= 2;
        }
        
        Console.WriteLine(Ans);
    }
}