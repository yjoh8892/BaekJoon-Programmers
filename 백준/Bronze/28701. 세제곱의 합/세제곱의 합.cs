using System;

class Q28701
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        
        for (int i = 1; i <= N; i++) {
            sum1 += i;
        }
        
        for (int i = 1; i <= N; i++) {
            sum2 += i * i * i;
        }
        
        Console.WriteLine(sum1);
        Console.WriteLine(sum1 * sum1);
        Console.WriteLine(sum2);
    }
}