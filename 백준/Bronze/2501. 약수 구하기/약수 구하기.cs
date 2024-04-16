using System;

class Q2501
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        int N = int.Parse(S[0]);
        int K = int.Parse(S[1]);
        int count = 0;
        int Ans = 0;
        
        for (int i = 1; i <= N; i++)
        {
            if (N % i == 0)
            {
                count++;
            }
            
            if (count == K)
            {
                Ans = i;
                break;
            }
        }
        
        Console.WriteLine(Ans);
    }
}