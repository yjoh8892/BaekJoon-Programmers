using System;

class Q3009
{
    static void Main(string[] args)
    {
        int[] x = new int[3];
        int[] y = new int[3];
        
        for (int i = 0; i < 3; i++)
        {
            string[] S = Console.ReadLine().Split();
            x[i] = int.Parse(S[0]);
            y[i] = int.Parse(S[1]);
        }
        
        int fpx;
        int fpy;
        
        if (x[0] == x[1])
        {
            fpx = x[2];
        }
        else if (x[0] == x[2])
        {
            fpx = x[1];
        }
        else
        {
            fpx = x[0];
        }
        
        if (y[0] == y[1])
        {
            fpy = y[2];
        }
        else if (y[0] == y[2]) 
        {
            fpy = y[1];
        }
        else
        {
            fpy = y[0];
        }
        
        Console.WriteLine(fpx + " " + fpy);
    }
}