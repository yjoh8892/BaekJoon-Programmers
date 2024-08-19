using System;

class Q17388
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        int S = int.Parse(s[0]);
        int K = int.Parse(s[1]);
        int H = int.Parse(s[2]);
        int sum = S + K + H;
        int min = Math.Min(S, K);
		min = Math.Min(min, H);
        
        if (sum >= 100)
        {
            Console.WriteLine("OK");
        }
        else
        {
            if (min == S)
            {
                Console.WriteLine("Soongsil");
            }
            else if (min == K)
            {
                Console.WriteLine("Korea");
            }
            else
            {
                Console.WriteLine("Hanyang");
            }
        }
    }
}