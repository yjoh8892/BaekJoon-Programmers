using System;

class Q2475
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        int C = int.Parse(S[2]);
        int D = int.Parse(S[3]);
        int E = int.Parse(S[4]);
        int sum = A * A + B * B + C * C + D * D + E * E;
        int result = sum % 10;
        
        Console.WriteLine(result);
    }
}