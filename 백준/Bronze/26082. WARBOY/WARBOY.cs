using System;

class Q26082
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        int C = int.Parse(S[2]);
        int ComResult = B / A;
        int D = 3 * ComResult * C;
        
        Console.WriteLine(D);
    }
}