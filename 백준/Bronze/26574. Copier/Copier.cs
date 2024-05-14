using System;

class Q26574
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++) {
            int k = int.Parse(Console.ReadLine());
            
            Console.WriteLine(k + " " + k);
        }
    }
}