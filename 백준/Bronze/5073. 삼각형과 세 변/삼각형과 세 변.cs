using System;

class Q5073
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] S = Console.ReadLine().Split();
            int[] arr = new int[3];
            
            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(S[i]);
            }
            
            if (arr[0] == 0 && arr[1] == 0 && arr[2] == 0)
            {
                break;
            }
            
            Array.Sort(arr);
            
            if (arr[2] >= arr[0] + arr[1])
            {
                Console.WriteLine("Invalid");
            }
            else if (arr[0] == arr[1] && arr[1] == arr[2])
            {
                Console.WriteLine("Equilateral");
            }
            else if (arr[0] == arr[1] || arr[0] == arr[2] || arr[1] == arr[2])
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
    }
}