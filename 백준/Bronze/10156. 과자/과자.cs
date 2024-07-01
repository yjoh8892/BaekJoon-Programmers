using System;

class Q1015
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int K = int.Parse(S[0]);
        int N = int.Parse(S[1]);
        int M = int.Parse(S[2]);
        int sum = K * N;
        
        if (M < sum)
        {
            Console.WriteLine(sum - M);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}