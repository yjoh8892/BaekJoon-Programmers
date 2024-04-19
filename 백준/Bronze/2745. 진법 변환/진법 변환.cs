using System;

class Q2745
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        string N = S[0];
        int B = int.Parse(S[1]);

        int answer = 0;
        int tmp = 1;
        
        for (int i = N.Length - 1; i >= 0; i--) {
            char C = N.ElementAt(i);
            
            if ('A' <= C && C <= 'Z') {
                answer += (C - 'A' + 10) * tmp;
            }
            else
            {
                answer += (C - '0') * tmp;
            }
            
            tmp *= B;
        }
        
        Console.WriteLine(answer);
    }
}