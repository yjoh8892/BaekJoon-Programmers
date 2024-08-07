using System;

class Q25238
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int a = int.Parse(S[0]);
        int b = int.Parse(S[1]);
        int result = a * (100 - b) / 100;
        
        if (result >= 100)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(1);
        }
    }
}