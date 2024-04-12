using System;

class Q10950
{
    static void Main(String[] args)
    {
        int T = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < T; i++)
        {
            String[] S = Console.ReadLine().Split();
            
            int A = int.Parse(S[0]);
            int B = int.Parse(S[1]);
            
            Console.WriteLine(A + B);
        }
    }
}