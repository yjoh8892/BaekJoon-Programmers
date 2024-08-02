using System;

class Q10768
{
    static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        
        if (m < 2)
        {
            Console.WriteLine("Before");
        }
        else if (m == 2)
        {
            if (d < 18)
            {
                Console.WriteLine("Before");
            }
            else if (d > 18)
            {
                Console.WriteLine("After");
            }
            else
            {
                Console.WriteLine("Special");
            }
        }
        else
        {
            Console.WriteLine("After");
        }
    }
}