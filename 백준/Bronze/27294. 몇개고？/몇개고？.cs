using System;

class Q27294 {
    static void Main(string[] args)
    {
        string[] SS = Console.ReadLine().Split();
        int T = int.Parse(SS[0]);
        int S = int.Parse(SS[1]);
        
        if (S == 0 && (T >= 12 && T <= 16))
        {
            Console.WriteLine(320);
        }
        else
        {
            Console.WriteLine(280);
        }
    }
}