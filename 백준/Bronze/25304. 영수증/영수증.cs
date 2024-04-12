using System;

class Q25304
{
    static void Main(String[] args)
    {
        int X = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int total = 0;
        
        for (int i = 0; i < N; i++)
        {
            String[] S = Console.ReadLine().Split();
            
            int a = int.Parse(S[0]);
            int b = int.Parse(S[1]);
            
            total += (a * b);
        }
        
        if (total == X)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}