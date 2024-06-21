using System;

class Q27324 {
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        if (N / 10 == N % 10)
        {
            Console.WriteLine(1);
        }
            else
        {
            Console.WriteLine(0);
        }
    }
}