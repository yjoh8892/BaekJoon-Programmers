using System;

class Q2884
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        
        int H = int.Parse(S[0]);
        int M = int.Parse(S[1]);
        
        M = M - 45;
        
        if (M < 0)
        {
            M = M + 60;
            H = H - 1;
        }
        
        if (H < 0)
        {
            H = H + 24;
        }
        
        Console.WriteLine(H + " " + M);
    }
}