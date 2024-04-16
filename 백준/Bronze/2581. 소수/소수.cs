using System;

class Q2581
{
    static void Main(String[] args)
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        
        int min = N;
        int sum = 0;
        int[] arr = new int[N + 1];
        
        for (int i = M; i <= N; i++)
        {
            bool check = true;
			
            if (i == 1)
            {
                continue;
            }
            
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    check = false;
					break;
				}
			}
            
            if (check)
            {
                arr[i] = i;
                sum += i;
            }
        }
        
        if (sum == 0) 
        {
            Console.WriteLine(-1);
        }
        else
        {
            for (int i = 0; i < N; i++)
            {
                if (min > arr[i] && arr[i] != 0)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(min);
        }
    }
}