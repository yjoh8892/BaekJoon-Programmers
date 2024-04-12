using System;

class Q2480
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        int C = int.Parse(S[2]);
        int Max;
        
        if (A == B && A == C) 
        {
            Console.WriteLine(10000 + A * 1000);
        }
        else if (A == B && A != C)
        {
            Console.WriteLine(1000 + A * 100);
        }
        else if (A != B && A == C)
        {
            Console.WriteLine(1000 + A * 100);
        }
        else if (B == C && B != A)
        {
            Console.WriteLine(1000 + B * 100);
        }
        else
        {
            if(A > B && A > C)
            {
                Max = A;
            }
            else if (B > A && B > C)
            {
                Max = B;
            }
            else
            {
                Max = C;
            }
            Console.WriteLine(Max * 100);
        }
    }
}