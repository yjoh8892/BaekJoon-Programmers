using System;

class Q14489
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        int C = int.Parse(Console.ReadLine());
        
        if (A + B < 2 * C)
        {
            Console.WriteLine(A + B);
        }
        else
        {
            Console.WriteLine((A + B) - 2 * C);
        }
    }
}