using System;

class Q1193
{
    static void Main(string[] args) 
    {
        int X = int.Parse(Console.ReadLine());
        int i = 0;
		int val = 0;
		
        while (val < X) {
            i++;
            val += i;
		}
		
		if(i % 2 == 0)
        {
			Console.WriteLine((i - (val - X)) + "/" + (i + (((val - i) - X) + 1)));
		}
        else
        {
			Console.WriteLine((i + (((val - i) - X) + 1)) + "/" + (i - (val - X)));
		}
    }
}