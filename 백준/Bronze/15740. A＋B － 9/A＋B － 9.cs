using System;
using System.Numerics;

class Q15740
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        BigInteger A = BigInteger.Parse(S[0]);
        BigInteger B = BigInteger.Parse(S[1]);
        
        Console.WriteLine(A + B);
    }
} 