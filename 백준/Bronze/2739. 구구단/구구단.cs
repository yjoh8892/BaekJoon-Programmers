using System;

class Q2739
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(N + " * " + i + " = " +  N * i);
        }
    }
}