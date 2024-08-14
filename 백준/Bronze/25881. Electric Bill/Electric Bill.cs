using System;

class Q25881
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int first = int.Parse(S[0]);
        int additional = int.Parse(S[1]);
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            int energy = int.Parse(Console.ReadLine());
            int money = 0;
            
            if (energy <= 1000)
            {
                money = first * energy;
            }
            else
            {
                money = first * 1000 + additional * (energy - 1000);
            }
            Console.WriteLine(energy + " " + money);
        }
    }
}