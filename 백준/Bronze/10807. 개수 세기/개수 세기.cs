using System;

class Q10807
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        String[] S = Console.ReadLine().Split();
        String Ans = Console.ReadLine();
        
        int result = Array.FindAll(S, x => x == Ans).Length;
        
        Console.WriteLine(result);
    }
}