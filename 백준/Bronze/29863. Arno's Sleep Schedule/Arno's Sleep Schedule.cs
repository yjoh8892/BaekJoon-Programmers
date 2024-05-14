using System;

class Q29863
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int Ans = (24 - A) + B;
       
        if (Ans >= 24) {
            Ans -= 24;
        }
        
        Console.WriteLine(Ans);
    }
}