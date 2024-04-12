using System;

class Q10869
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        
        Console.WriteLine(int.Parse(S[0]) + int.Parse(S[1]));
        Console.WriteLine(int.Parse(S[0]) - int.Parse(S[1]));
        Console.WriteLine(int.Parse(S[0]) * int.Parse(S[1]));
        Console.WriteLine(int.Parse(S[0]) / int.Parse(S[1]));
        Console.WriteLine(int.Parse(S[0]) % int.Parse(S[1]));
    }
}