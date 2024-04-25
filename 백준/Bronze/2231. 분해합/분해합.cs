using System;

class Q2231
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int ans = 0;
        
        for (int i = 0; i < N; i++)
        {
			int num = i;
			int sum = 0;
			
			while (num != 0)
            {
				sum += num % 10;
				num /= 10;
			}
            
			if(sum + i == N)
            {
				ans = i;
				break;
			}
        }
        
        Console.WriteLine(ans);
    }
}