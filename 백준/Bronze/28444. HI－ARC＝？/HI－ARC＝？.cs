using System;

class Q28444 
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int H = int.Parse(S[0]);
        int I = int.Parse(S[1]);
        int A = int.Parse(S[2]);
        int R = int.Parse(S[3]);
        int C = int.Parse(S[4]);
        
        Console.WriteLine(H * I - A * R * C);
    }
}