using System;

class Q2750
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
            
        for (int i = 0; i < N; i++) {
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        Array.Sort(arr);
        
        for (int i = 0; i < N; i++) {
            Console.WriteLine(arr[i]);
        }
    }
}