using System;

class Q10952
{
    static void Main(String[] args)
    {
        while (true)
        {
            String[] S = Console.ReadLine().Split();
            
            int A = int.Parse(S[0]);
            int B = int.Parse(S[1]);
            
            if (A == 0 && B == 0)
            {
                break;
            }
            else 
            {
                Console.WriteLine(A + B);
            }
        }
    }
}