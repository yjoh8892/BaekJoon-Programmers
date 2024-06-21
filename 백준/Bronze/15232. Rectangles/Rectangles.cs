using System;

class Q15232
{
    static void Main(string[] args)
    {
        int R = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < R; i++) {
            for (int j = 0; j < C; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}