using System;

class Q23795
{
    static void Main(string[] args)
    {
        int sum = 0;
        
        while (true)
        {
            int A = int.Parse(Console.ReadLine());
            
            if (A == -1)
            {
                break;
            }
            
            sum += A;
        }
        
        Console.WriteLine(sum);
    }
}