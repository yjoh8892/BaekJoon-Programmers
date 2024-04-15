using System;

class Q10871
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        
        int N = int.Parse(S[0]);
        int X = int.Parse(S[1]);
        
        String[] A = Console.ReadLine().Split();
        
        int[] arr = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(A[i]);
            
            if (arr[i] < X)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}