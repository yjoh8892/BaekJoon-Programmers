using System;

class Q25305
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int N = int.Parse(S[0]);
        int k = int.Parse(S[1]);
        string[] grade = Console.ReadLine().Split();
        int[] arr = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(grade[i]);
        }
        
        Array.Sort(arr);
        
        Console.WriteLine(arr[N - k]);
    }
}