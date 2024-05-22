using System;

class Q10039
{
    static void Main(string[] args)
    {
        int sum = 0;
        
        for (int i = 0; i < 5; i++) {
            int N = int.Parse(Console.ReadLine());
            
            if (N <= 40) {
                N= 40;
            }
            
            sum += N;
        }
        
        Console.WriteLine(sum / 5);
    }
}