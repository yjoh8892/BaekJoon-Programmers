using System;

class Q2563
{
    static void Main(string[] args)
    {
        int[,] arr = new int[100,100];
        int N = int.Parse(Console.ReadLine());
        int count = 0;
        
        for (int i = 0; i < N; i++)
        {
            string[] S = Console.ReadLine().Split();
            int x = int.Parse(S[0]);
            int y = int.Parse(S[1]);
            
            for (int j = x; j < x + 10; j++)
            {
                for (int k = y; k < y + 10; k++)
                {
                    arr[j,k] = 1;
                }
            }
        }
        
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                if(arr[i,j] == 1)
                {
                    count++;
                }
            }
        }
        
        Console.WriteLine(count);
    }
}