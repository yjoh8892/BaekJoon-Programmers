using System;

class Q10797
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        string[] S = Console.ReadLine().Split();
        
        for (int i = 0; i < 5; i++)
        {
            int m = int.Parse(S[i]);
            
            if (m % 10 == n)
            {
                count++;
            }
        }
        
        Console.WriteLine(count);
    }
}