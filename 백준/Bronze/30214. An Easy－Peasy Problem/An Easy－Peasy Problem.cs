using System;

class Q30214
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int s1 = int.Parse(S[0]);
        int s2 = int.Parse(S[1]);
        
        if (2 * s1 >= s2) {
            Console.WriteLine('E');
        } else {
            Console.WriteLine('H');
        }
    }
}