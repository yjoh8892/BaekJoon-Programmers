using System;

class Q8370
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int n1 = int.Parse(S[0]);
        int k1 = int.Parse(S[1]);
        int n2 = int.Parse(S[2]);
        int k2 = int.Parse(S[3]);
        
        Console.WriteLine(n1 * k1 + n2 * k2);
    }
}