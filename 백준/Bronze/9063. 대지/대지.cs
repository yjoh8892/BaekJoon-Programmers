using System;

class Q9063
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] x = new int[N];
        int[] y = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            string[] S = Console.ReadLine().Split();
            x[i] = int.Parse(S[0]);
            y[i] = int.Parse(S[1]);
        }
        
        Array.Sort(x);
		Array.Sort(y);
		
		Console.Write((x[N - 1] - x[0]) * (y[N - 1] - y[0]));
    }
}