using System;

class Q9086
{
    static void Main(String[] args)
    {
        int T = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < T; i++)
        {
            String S = Console.ReadLine();
            
            Console.WriteLine(S.ElementAt(0) + "" + S.ElementAt(S.Length - 1));
        }
    }
}