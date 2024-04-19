using System;

class Q2587 {
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        
        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        int sum = 0;
        
        for (int i = 0; i < 5; i++)
        {
            sum += arr[i];
        }
        
        Array.Sort(arr);
        
        Console.WriteLine(sum / 5);
        Console.WriteLine(arr[2]);
    }
}