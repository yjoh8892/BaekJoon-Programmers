using System;

class Q10872
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int mul = 1;
        
        if (N == 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            for (int i = N; i >= 1; i--)
            {
                mul *= i;
            }
            
            Console.WriteLine(mul);
        }
    }
}