using System;

class Q9506
{
    static void Main(String[] args)
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            
            if (n == -1)
            {
                break;
            }
            
            int sum = 0;
            int count = 0;
            int[] arr = new int[n];
            
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && n != i)
                {
                    arr[count] = i;
                    count++;
                    sum += i;
                }
            }
            
            if (n == sum)
            {
                Console.Write(n + " = ");
                
                for (int i = 0; i < n; i++)
                {
                    if (n / 2 == arr[i])
                    {
                        Console.WriteLine(arr[i]);
                    }
                    else if (arr[i] != 0)
                    {
                        Console.Write(arr[i] + " + ");
                    }
                }
            }
            else if (n != sum)
            {
                Console.WriteLine(n + " is NOT perfect.");
            }
        }
    }
}