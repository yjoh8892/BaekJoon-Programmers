using System;

class Q8545
{
    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        string NewS = new string(S.ToCharArray().Reverse().ToArray());
        
        Console.WriteLine(NewS);
    }
}