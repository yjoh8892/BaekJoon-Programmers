using System;

class Q29163
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int even = 0;
        int odd = 0;
        string[] S = Console.ReadLine().Split();
        int[] arr = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(S[i]);
            
            if (arr[i] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }
        
        if (even > odd)
        {
            Console.WriteLine("Happy");
        }
        else
        {
            Console.WriteLine("Sad");
        }
    }
}