using System;

class Q5597
{
    static void Main(String[] args)
    {
        int[] arr = new int[31];
        
        for(int i = 1; i < 29; i++)
        {
            int suc = int.Parse(Console.ReadLine());
            arr[suc] = 1;
        }
        
        for(int i = 1; i < arr.Length; i++)
        {
            if(arr[i] != 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}