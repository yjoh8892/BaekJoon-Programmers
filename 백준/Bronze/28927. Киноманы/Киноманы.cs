using System;

class Q28927
{
    static void Main(string[] args)
    {
        string[] S1 = Console.ReadLine().Split();
        string[] S2 = Console.ReadLine().Split();
        int t1 = int.Parse(S1[0]);
        int e1 = int.Parse(S1[1]);
        int f1 = int.Parse(S1[2]);
        int t2 = int.Parse(S2[0]);
        int e2 = int.Parse(S2[1]);
        int f2 = int.Parse(S2[2]);
        
        int Max = 3 * t1 + 20 * e1 + 120 * f1;
        int Mel = 3 * t2 + 20 * e2 + 120 * f2;
        
        if (Max > Mel) {
            Console.WriteLine("Max");
        } else if (Mel > Max) {
            Console.WriteLine("Mel");
        } else {
            Console.WriteLine("Draw");
        }
    }
}