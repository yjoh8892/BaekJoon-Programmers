using System;

class Q1157
{
    static void Main(string[] args)
    {
        var word = Console.ReadLine()!;
        var cntAlphabets = new int[26];
        
        foreach (var c in word.ToUpper())
        {
            cntAlphabets[c - 'A']++;
        }
       
        var cntMax = cntAlphabets.Max();
        var freqMax = cntAlphabets.Count(cnt => cnt == cntMax);
        if (freqMax > 1)
        {
            Console.WriteLine("?");
        }
        else
        {
            Console.WriteLine((char)(Array.IndexOf(cntAlphabets, cntMax) + 'A'));
        }
    }
}