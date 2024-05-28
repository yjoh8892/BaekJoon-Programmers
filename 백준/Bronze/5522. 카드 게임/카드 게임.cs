using System;

class Q5522
{
    static void Main(string[] args)
    {
        int sum = 0;
        
        for (int i = 0; i < 5; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine(sum);
    }
}