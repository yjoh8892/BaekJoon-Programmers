using System;

class Q11050
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        int N = int.Parse(S[0]);
        int K = int.Parse(S[1]);
        
        if (N == K || N == 0 || K == 0)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine(Factorial(N) / (Factorial(K) * Factorial(N - K)));
        }
    }
    
    static int Factorial(int N)
    {
        if (N == 1)
        {
            return 1;
        }
        else
        {
            return N * Factorial(N - 1);
        }
    }
}