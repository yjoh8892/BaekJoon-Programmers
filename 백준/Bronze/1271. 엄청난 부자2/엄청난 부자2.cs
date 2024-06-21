using System;
using System.Numerics;

class Q1271
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        BigInteger n = BigInteger.Parse(S[0]);
        BigInteger m = BigInteger.Parse(S[1]);
        
        Console.WriteLine(n / m);
        Console.WriteLine(n % m);
    }
}