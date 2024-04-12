using System;

class Q1330
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        
        if (A > B)
        {
            Console.WriteLine(">");
        } 
        else if (A < B)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("==");
        }
    }
}