using System;

class Q11382
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        
        long A = long.Parse(S[0]);
        long B = long.Parse(S[1]);
        long C = long.Parse(S[2]);
        
        Console.WriteLine(A + B + C);
    }
}