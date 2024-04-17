using System;

class Q24313
{
    static void Main(String[] args)
    {
        string[] S = Console.ReadLine().Split();
        int a_1 = int.Parse(S[0]);
        int a_0 = int.Parse(S[1]);
        int c = int.Parse(Console.ReadLine());
        int n_0 = int.Parse(Console.ReadLine());
        
        if (a_1 * n_0 + a_0 <= c * n_0 && c >= a_1) {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}