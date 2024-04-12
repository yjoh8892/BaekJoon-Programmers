using System;

class Q9498
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        if (N >= 90 && N <= 100)
        {
            Console.WriteLine('A');
        }
        else if (N >= 80 && N <= 89)
        {
            Console.WriteLine('B');
        }
        else if (N >= 70 && N <= 79)
        {
            Console.WriteLine('C');
        }
        else if (N >= 60 && N <= 69)
        {
            Console.WriteLine('D');
        }
        else
        {
            Console.WriteLine('F');
        }
    }
}