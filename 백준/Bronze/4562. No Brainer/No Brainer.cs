using System;

class Q4562
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string[] S = Console.ReadLine().Split();
            int X = int.Parse(S[0]);
            int Y = int.Parse(S[1]);
            
            if (X < Y)
            {
                Console.WriteLine("NO BRAINS");
            }
            else
            {
                Console.WriteLine("MMM BRAINS");
            }
        }
    }
}