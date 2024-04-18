using System;

class Q10101
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        
        if (A + B + C != 180)
        {
            Console.WriteLine("Error");
        }
        else
        {
            if (A == B && B == C && A == C)
            {
                Console.WriteLine("Equilateral");
            }
            else if (A != B && B != C && A!= C)
            {
                Console.WriteLine("Scalene");
            }
            else
            {
                Console.WriteLine("Isosceles");
            }
        }
    }
}