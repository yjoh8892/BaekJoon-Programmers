using System;

class Q2562
{
    static void Main(String[] args)
    {
        int N = 9;
        int[] arr = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        int Max = 0;
        int count = 0;
        int index = 0;
        
        for (int i = 0; i < N; i++)
        {
            count++;
            
            if (Max < arr[i])
            {
                Max = arr[i];
                index = count;
            }
        }
        
        Console.WriteLine(Max);
        Console.WriteLine(index);
    }
}