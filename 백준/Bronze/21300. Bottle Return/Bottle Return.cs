using System;

class Q21300
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int sum = 0;
        
        for (int i = 0; i < 6; i++) {
            sum += int.Parse(S[i]);
        }
        
        Console.WriteLine(5 * sum);
    }
}