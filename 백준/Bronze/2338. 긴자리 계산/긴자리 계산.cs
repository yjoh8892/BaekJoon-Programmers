using System;
using System.Numerics;

class Q2338
{
    static void Main(string[] args)
    {
        BigInteger A = BigInteger.Parse(Console.ReadLine());
        BigInteger B = BigInteger.Parse(Console.ReadLine());
        BigInteger sum = A + B;
        BigInteger sub = A - B;
        BigInteger mul = A * B;
        
        Console.WriteLine(sum);
        Console.WriteLine(sub);
        Console.WriteLine(mul);
    }
}