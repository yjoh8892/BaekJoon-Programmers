using System;

class Q19532
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        int a = int.Parse(S[0]);
        int b = int.Parse(S[1]);
        int c = int.Parse(S[2]);
        int d = int.Parse(S[3]);
        int e = int.Parse(S[4]);
        int f = int.Parse(S[5]);
        
        for (int i = -999; i <= 999; i++) 
        {
            for (int j = -999; j <= 999; j++)
            {
                if (a * i + b * j == c && d * i + e * j == f)
                {
                    Console.WriteLine(i + " " + j); 
                }
            }
        }
    }
}