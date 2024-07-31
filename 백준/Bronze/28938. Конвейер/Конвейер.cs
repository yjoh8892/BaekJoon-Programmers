using System;

class Q28938
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] S = Console.ReadLine().Split();
        int sum = 0;
        
        for (int i = 0; i < n; i++)
        {
            sum += int.Parse(S[i]);
        }
        
        if (sum > 0)
        {
            Console.WriteLine("Right");
        }
        else if (sum < 0)
        {
            Console.WriteLine("Left");
        }
        else
        {
            Console.WriteLine("Stay");
        }
    } 
}