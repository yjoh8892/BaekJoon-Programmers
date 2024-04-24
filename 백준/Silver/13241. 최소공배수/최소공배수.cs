using System;

class Q13241
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        long A = long.Parse(S[0]);
        long B = long.Parse(S[1]);
        long gcd = getGCD(Math.Max(A, B), Math.Min(A, B));
        
        Console.WriteLine(A * B / gcd);
    }
    
    public static long getGCD(long A, long B)
    {
        while (B > 0)
        {
            long tmp = A;
            A = B;
            B = tmp % B;
        }
        
        return A;
    }
}