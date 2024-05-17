using System;

class Q27959
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int N = int.Parse(S[0]);
        int M = int.Parse(S[1]);
        
        if (100 * N >= M)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}