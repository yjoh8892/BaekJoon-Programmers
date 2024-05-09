using System;

class Q31654
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        int C = int.Parse(S[2]);
        
        if (A + B == C)
        {
            Console.WriteLine("correct!");
        }
        else
        {
            Console.WriteLine("wrong!");
        }
    }
}