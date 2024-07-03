using System;

class Q5532
{
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        
        int kor = 0;
		int math = 0;
        
        if (A % C == 0)
        {
			kor = L - (A / C);
		}
        else
        {
			kor = L - (A / C + 1);
		}

		if (B % D == 0)
        {
			math = L - (B / D);
		}
        else
        {
			math = L - (B / D + 1);
		}

		Console.WriteLine(Math.Min(kor, math));
    }
}