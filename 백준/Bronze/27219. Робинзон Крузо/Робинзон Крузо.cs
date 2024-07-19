using System;

class Q27219
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
		for (int i = 0; i < n / 5 ; i++) {
			Console.Write("V");
		}
		
		for (int i = 0; i < n % 5; i++) {
			Console.Write("I");
		}
	}
}