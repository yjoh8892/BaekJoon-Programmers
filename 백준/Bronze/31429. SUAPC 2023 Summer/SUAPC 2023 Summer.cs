using System;

class Q31429
{
    static void Main(string[] arsgs)
    {
        int N = int.Parse(Console.ReadLine());
        int[] question = {12, 11, 11, 10, 9, 9, 9, 8, 7, 6, 6};
        int[] penalty = {1600, 894, 1327, 1311, 1004, 1178, 1357, 837, 1055, 556, 773};
        
        Console.WriteLine(question[N - 1] + " " + penalty[N - 1]);
    }
}