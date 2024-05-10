using System;

class Q31611
{
    static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine());
        
        if (X == 0 || X == 1)
        {
            Console.WriteLine(0);
        }
        else if ((X - 2) % 7 == 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}