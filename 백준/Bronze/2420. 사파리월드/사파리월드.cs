using System;
using System.Numerics;

class Q2420
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        long N = int.Parse(S[0]);
        long M = int.Parse(S[1]);
        
        Console.WriteLine(Math.Abs(N - M));
    }
}