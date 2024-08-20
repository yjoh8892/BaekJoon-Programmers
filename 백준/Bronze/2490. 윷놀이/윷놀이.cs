using System;

class Q2490
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            int sum = 0;
            string[] S = Console.ReadLine().Split();
            
            for (int j = 0; j < 4; j++)
            {
                sum += int.Parse(S[j]);
            }
            
            if (sum == 4)
            {
                Console.WriteLine("E");
            }
            else if (sum == 3)
            {
                Console.WriteLine("A");
            }
            else if (sum == 2)
            {
                Console.WriteLine("B");
            }
            else if (sum == 1)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("D");
            }
        }
    }
}