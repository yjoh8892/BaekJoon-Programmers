using System;

class Q31450
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int M = int.Parse(S[0]);
        int K = int.Parse(S[1]);
        
        if (M % K == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}