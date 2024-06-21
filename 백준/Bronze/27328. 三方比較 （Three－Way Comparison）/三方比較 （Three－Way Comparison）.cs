using System;

class Q27328 
{
    static void Main(string[] args)
{
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        
        if (A < B)
        {
            Console.WriteLine(-1);
        }
        else if (A == B)
        {
            Console.WriteLine(-0);
        }
        else
        {
            Console.WriteLine(1);
        }
    }
} 