using System;

class Q2798
{
    static void Main(String[] args) 
    {
        String[] S = Console.ReadLine().Split();
        int N = int.Parse(S[0]);
        int M = int.Parse(S[1]);
        int[] arr = new int[M];
        int result = 0;
        
        String[] St = Console.ReadLine().Split();
        
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(St[i]);
        }
        
        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                for (int k = j + 1; k < N; k++)
                {
                    int sum = arr[i] + arr[j] + arr[k];

                    if (result < sum && sum <= M)
                    {
                        result = sum;
                    }
                }
            }
        }
        
        Console.WriteLine(result);
    }
}