using System;

class Q20492 
{
    static void Main(string[] args)
    {
        double N = double.Parse(Console.ReadLine());
        double No1 = N * 0.78;
        double No2 = N * 0.8 + N * 0.2 * 0.78;
        
        Console.WriteLine((int)No1 + " " + (int)No2);
    }
}