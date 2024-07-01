using System;

class Q20254
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int UR = int.Parse(S[0]);
        int TR = int.Parse(S[1]);
        int UO = int.Parse(S[2]);
        int TO = int.Parse(S[3]);
        int sum = 56 * UR + 24 * TR + 14 * UO + 6 * TO;
        
        Console.WriteLine(sum);
    }
}