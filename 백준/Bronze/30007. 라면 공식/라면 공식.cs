using System;

class Q30007
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < N; i++)
        {
            string[] S = Console.ReadLine().Split();
            int A = int.Parse(S[0]);
            int B = int.Parse(S[1]);
            int X = int.Parse(S[2]);;
            int W = A * (X - 1) + B;
            
            Console.WriteLine(W);
        }
    }
}