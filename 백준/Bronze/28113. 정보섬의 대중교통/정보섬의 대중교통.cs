using System;

class Q28113 {
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int N = int.Parse(S[0]);
        int A = int.Parse(S[1]);
        int B = int.Parse(S[2]);
        
        if (N <= B && B == A)
        {
			Console.WriteLine("Anything");
		}
        else if (N <= B && B - A > 0)
        {
			Console.WriteLine("Bus");
		}
        else
        {
			Console.WriteLine("Subway");
		}
    }
}