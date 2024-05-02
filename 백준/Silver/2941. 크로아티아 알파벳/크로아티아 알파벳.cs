using System;

class Q2941
{
    static void Main(string[] args)
    {
        string[] croatiaAlphabets = {"c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z="};
        var word = Console.ReadLine()!;
        
        foreach (string alphabet in croatiaAlphabets)
        {
            while (word.Contains(alphabet))
            {
                word = word.Replace(alphabet, "a");
            }
        }

        Console.WriteLine(word.Length);
    }
}