using System;

class Q2720
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        int[] arr = new int[T];
        int Q = 25;
        int D = 10;
        int N = 5;
        int P = 1;
        
        for (int i = 0; i < T; i++)
        {
            int C = int.Parse(Console.ReadLine());
            int ResultQ = C / Q;
            int ResultD = (C % Q) / D;
            int ResultN = ((C % Q) % D) / N;
            int ResultP = (((C % Q) % D) % N) / P;
            
            Console.WriteLine(ResultQ + " " + ResultD + " " + ResultN + " " + ResultP);
        }
    }
}