using System;

class Q18301
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int n1 = int.Parse(S[0]);
        int n2 = int.Parse(S[1]);
        int n3 = int.Parse(S[2]);
        
        Console.WriteLine((n1 + 1) * (n2 + 1) / (n3 + 1) - 1);
    }
}