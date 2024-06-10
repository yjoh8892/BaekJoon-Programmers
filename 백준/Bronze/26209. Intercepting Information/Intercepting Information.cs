using System;

class Q26209
{
    static void Main(string[] args)
    {
        int[] N = new int[8];
        int count = 0;
        string[] S = Console.ReadLine().Split();
        
		for (int i = 0; i < 8; i++)
        {
			N[i] = int.Parse(S[i]);
		}
		
		for (int i = 0; i < 8; i++)
        {
			if (N[i] == 0 || N[i] == 1)
            {
                count++;
			}
            else
            {
				break;
			}
		}
		
		if (count == 8)
        {
			Console.WriteLine("S");
		}
        else
        {
			Console.WriteLine("F");
		}
    }
}