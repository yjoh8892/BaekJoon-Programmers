using System;

class Q10811
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        int N = int.Parse(S[0]);
        int M = int.Parse(S[1]);
        int[] basket = new int[N + 1];
        
        for(int i = 1; i <= N; i++)
        {
            basket[i] = i;
        }
        
        for(int i = 0; i < M; i++)
        {
            String[] num = Console.ReadLine().Split();
            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);
            
            while(A < B) 
            {
				int temp = basket[A];
				basket[A++] = basket[B];
				basket[B--] = temp;
			}
        }
        
        for(int i = 1; i <= N; i++)
        {
            Console.Write(basket[i] + " ");
        }
    }
}