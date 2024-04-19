using System;

class Q2738
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int N = int.Parse(S[0]);
        int M = int.Parse(S[1]);
        int[,] arr1 = new int[N,M];
        int[,] arr2 = new int[N,M];
        
        for (int i = 0; i < N; i++)
        {
            string[] line1 = Console.ReadLine().Split();
            for (int j = 0; j < M; j++)
            {
                arr1[i,j] = int.Parse(line1[j]);
            }
        }

        for (int i = 0; i < N; i++)
        {
            string[] line2 = Console.ReadLine().Split();
            for (int j = 0; j < M; j++)
            {
                arr2[i,j] = int.Parse(line2[j]);
            }
        }
        
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(arr1[i,j] + arr2[i,j] + " ");
            }
        } 
    }
}