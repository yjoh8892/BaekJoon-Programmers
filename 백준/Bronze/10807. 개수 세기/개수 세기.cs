using System;

class Q10807
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        String[] S = Console.ReadLine().Split();
        String v = Console.ReadLine();
        
        int Ans = Array.FindAll(S, x => x == v).Length;
        
        Console.WriteLine(Ans);
    }
}