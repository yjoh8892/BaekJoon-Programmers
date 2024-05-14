using System;

class Q29751
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int W = int.Parse(S[0]);
        int H = int.Parse(S[1]);
        double Ans = (double) W * H / 2;
        
        Console.WriteLine(Ans.ToString("F1"));
    }
}