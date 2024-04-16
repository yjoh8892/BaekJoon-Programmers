using System;

class Q5086
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
            
            if (B % A == 0)
            {
                Console.WriteLine("factor");
            }
            else if (A % B == 0)
            {
                Console.WriteLine("multiple");
            }
            else
            {
                Console.WriteLine("neither");
            }
        }
    }
}