using System;

class Q11005
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int N = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        
        char[] arr = new char[36];
		
		for (int i = 0; i < 10; i++)
        {
			arr[i] = (char) (i + '0');
		}
        
		for (int i = 10; i < 36; i++)
        {
			arr[i] = (char) (i + 'A' - 10);
		}
        
		long result = 0;
		String re = "";
        
		while (N > 0) {
			result = N % B;
			N = N / B;
			re = arr[(int) result] + re;
		}
        
		Console.Write(re);
    }
}