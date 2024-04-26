using System;

class Q2559
{
    static void Main(string[] args)
    {
        string[] S1 = Console.ReadLine().Split();
        int N = int.Parse(S1[0]);
        int K = int.Parse(S1[1]);
        
        int[] temp = new int[N];
        string[] S2 = Console.ReadLine().Split();
        int max = Int32.MinValue;
        
        for (int i = 0; i < N; i++)
        {
            temp[i] = int.Parse(S2[i]);
        }
        
        for (int i = 0; i < N - K + 1; i++)
        {
            int sum = 0;
            
            for (int j = i; j < i + K; j++)
            {
                sum += temp[j];
            }
            
            max = Math.Max(max, sum);
        }
        
        Console.WriteLine(max);
    }
}