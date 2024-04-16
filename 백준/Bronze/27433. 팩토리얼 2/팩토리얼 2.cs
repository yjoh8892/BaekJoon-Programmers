using System;

class Q27433
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        Console.WriteLine(factorial(N));
    }
    
    static long factorial(long n) {
        if (n == 0 || n == 1) {
            return 1;
        } else {
            return n * factorial(n - 1);
        }
    }
}