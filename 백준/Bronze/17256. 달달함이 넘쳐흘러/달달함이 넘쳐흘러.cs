using System;

class Q17256
{
    static void Main(string[] args)
    {
        string[] S1 = Console.ReadLine().Split();
        int ax = int.Parse(S1[0]);
        int ay = int.Parse(S1[1]);
        int az = int.Parse(S1[2]);
        string[] S2 = Console.ReadLine().Split();
        int cx = int.Parse(S2[0]);
        int cy = int.Parse(S2[1]);
        int cz = int.Parse(S2[2]);
        
        Console.WriteLine((cx - az) + " " + cy / ay + " " + (cz - ax));
    }
}