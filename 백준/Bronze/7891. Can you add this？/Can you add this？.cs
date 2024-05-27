using System;

class Q7891
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < t; i++)
        {
            string[] S = Console.ReadLine().Split();
            int x = int.Parse(S[0]);
            int y = int.Parse(S[1]);
            
            Console.WriteLine(x + y);            
        }
    }
}