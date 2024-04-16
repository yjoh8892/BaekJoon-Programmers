using System;

class Q1085
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        int x = int.Parse(S[0]);
        int y = int.Parse(S[1]);
        int w = int.Parse(S[2]);
        int h = int.Parse(S[3]);
        int[] arr = new int[4];
        w = w - x;
        h = h - y;
        
        arr[0] = x;
        arr[1] = y;
        arr[2] = w;
        arr[3] = h;
        
        Array.Sort(arr);
        Console.WriteLine(arr[0]);
    }
}