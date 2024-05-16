using System;

class Q26307
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int HH = int.Parse(S[0]);
        int MM = int.Parse(S[1]);
        
        Console.WriteLine((HH - 9) * 60 + MM);
    }
}