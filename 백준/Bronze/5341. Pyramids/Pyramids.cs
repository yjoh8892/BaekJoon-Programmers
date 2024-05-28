using System;

class Q5341
{
    static void Main(string[] args)
    {
        while (true) {
            int N = int.Parse(Console.ReadLine());
            
            if (N == 0) {
                break;
            }
            
            Console.WriteLine(N * (N + 1) / 2);
        }
    }
}