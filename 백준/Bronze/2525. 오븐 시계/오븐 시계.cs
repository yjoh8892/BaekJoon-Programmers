using System;

class Q2525
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        int C = int.Parse(Console.ReadLine());
        
        B = B + C;
        
        while (B >= 60)
        {
            B = B - 60;
            A = A + 1;
        }
        
        if (A >= 24)
        {
            A = A - 24;
        }
        
        Console.WriteLine(A + " " + B);
    }
}