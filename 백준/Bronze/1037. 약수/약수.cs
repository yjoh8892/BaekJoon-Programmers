using System;

class Q1037
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        string[] S = Console.ReadLine().Split();
        
        for (int i = 0; i < N; i++) 
        {
            arr[i] = int.Parse(S[i]);
        }
        
        Array.Sort(arr);
        Console.WriteLine(arr[0] * arr[N - 1]);
    }
}