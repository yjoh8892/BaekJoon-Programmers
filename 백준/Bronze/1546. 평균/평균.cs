using System;

class Q1546
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        double[] arr = new double[N];
        
        String[] S = Console.ReadLine().Split();
        
        for(int i = 0; i < N; i++)
        {
            arr[i] = double.Parse(S[i]);
        }
        
        Array.Sort(arr);
        double sum = 0;
        
        for(int i = 0; i < N; i++)
        {
            sum += arr[i] / arr[N - 1] * 100;
        }
        
        Console.WriteLine(sum / N);
        
    }
}