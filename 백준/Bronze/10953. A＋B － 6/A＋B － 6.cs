using System;

class Q10953
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < T; i++)
        {
            string[] S = Console.ReadLine()!.Split(',');
            int A = int.Parse(S![0]);
            int B = int.Parse(S![1]);
            
            Console.WriteLine(A + B);
        }
    }
}