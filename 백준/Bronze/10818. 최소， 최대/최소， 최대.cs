using System;

class Q10818
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        String[] S = Console.ReadLine().Split();
        
        int[] arr = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(S[i]);
        }
        
        Array.Sort(arr);
        
        Console.Write(arr[0] + " " + arr[N - 1]);
    }
}