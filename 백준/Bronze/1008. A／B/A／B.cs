using System;

class Q1008
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        
        double A = double.Parse(S[0]);
        double B = double.Parse(S[1]);
        
        Console.WriteLine(A / B);
    }
}