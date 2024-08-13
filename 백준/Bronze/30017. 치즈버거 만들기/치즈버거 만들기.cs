using System;

class Q30017
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        
        if (A > B)
        {
            Console.WriteLine(B + (B + 1));
        }
        else
        {
            Console.WriteLine(A + (A - 1));
        }
    }
}