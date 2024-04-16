using System;

class Q10870 {
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine(Fibonacci(n));
    }
    
    static int Fibonacci(int n) {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}