using System;

class Q16430
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        int C = B - A;
        
        Console.WriteLine(C + " " + B);
    }
}