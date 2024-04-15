using System;

class Q10810
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        int N = int.Parse(S[0]);
        int M = int.Parse(S[1]);
        int[] basket = new int[N];
        
        for(int i = 0; i < N; i++)
        {
            basket[i] = 0;
        }
        
        for(int i = 0; i < M; i++)
        {
            String[] num = Console.ReadLine().Split();
            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);
            int C = int.Parse(num[2]);
            
            for(int j = A - 1; j < B; j++)
            {
                basket[j] = C;
            }
        }
        
        for(int i = 0; i < N; i++)
        {
            Console.Write(basket[i] + " ");
        }
    }
}