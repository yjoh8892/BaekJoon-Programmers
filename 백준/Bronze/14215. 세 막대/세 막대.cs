using System;

class Q14215
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int[] arr = new int[3];
        int Max = 0;
        
        for (int i = 0; i < 3; i++)
        {
            arr[i] = int.Parse(S[i]);
        }
        
        if (arr[0] > arr[1])
        {
            if (arr[1] > arr[2])
            {
                Max = arr[0];
            }
            else
            {
                Max = (arr[0] > arr[2]) ? arr[0] : arr[2];
            }
        }
        else
        {
            Max = (arr[1] > arr[2]) ? arr[1] : arr[2];
        }
        
        if (arr[0] + arr[1] + arr[2] - Max > Max)
        {
            Console.WriteLine(arr[0] + arr[1] + arr[2]);
        }
        else
        {
            Console.WriteLine((arr[0] + arr[1] + arr[2] - Max) * 2 - 1) ;
        }
    }
}