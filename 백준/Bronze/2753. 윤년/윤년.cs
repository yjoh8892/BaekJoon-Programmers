using System;

class Q2753
{
    static void Main(String[] args)
    {
        int Y = int.Parse(Console.ReadLine());
        
        if (Y % 4 == 0 && Y % 100 != 0 || Y % 400 == 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}