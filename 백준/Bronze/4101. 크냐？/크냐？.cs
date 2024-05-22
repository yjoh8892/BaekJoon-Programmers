using System;

class Q4101
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] S = Console.ReadLine().Split();
            int a = int.Parse(S[0]);
            int b = int.Parse(S[1]);
            
            if (a == 0 && b == 0)
            {
                break;
            }
            
            if (a > b)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}