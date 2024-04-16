using System;

class Q2839
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        if (N == 4 || N == 7)
        {
			Console.WriteLine(-1);
		}
		else if (N % 5 == 0)
        {
			Console.WriteLine(N / 5);
		}
		else if (N % 5 == 1 || N % 5 == 3)
        {
			Console.WriteLine((N / 5) + 1);
		}
		else
        {
			Console.WriteLine((N / 5) + 2);
		}
    }
}