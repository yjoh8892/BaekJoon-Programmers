using System;

class Q15727 
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        int count = 0;
        
        while (t > 0)
        {
            t -= 5;
            count++;
        }
        
        Console.WriteLine(count);
    }
}