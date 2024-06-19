using System;

class Q15964
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        long A = long.Parse(S[0]);
        long B = long.Parse(S[1]);
        long Ans = (A + B) * (A - B);
        
        Console.WriteLine(Ans);
    }
}