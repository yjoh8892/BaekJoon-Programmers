using System;
using System.Numerics;

class Q22193
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int N = int.Parse(S[0]);
        int M = int.Parse(S[0]);
        BigInteger A = BigInteger.Parse(Console.ReadLine());
        BigInteger B = BigInteger.Parse(Console.ReadLine());
        
        Console.WriteLine(A * B);
    }
}