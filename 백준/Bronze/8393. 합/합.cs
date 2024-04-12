using System;

class Q8393
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        
        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }
        
        Console.WriteLine(sum);
    }
}