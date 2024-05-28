using System;

class Q25372
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < N; i++)
        {
            String S = Console.ReadLine();
            
            if (S.Length >= 6 && S.Length <= 9)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}