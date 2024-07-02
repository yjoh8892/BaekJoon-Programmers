using System;

class Q3046
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();
        int R1 = int.Parse(s[0]);
        int S = int.Parse(s[1]);
        
        Console.WriteLine(2 * S - R1);
    }
}