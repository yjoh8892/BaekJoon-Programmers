using System;

class Q1436
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int num = 666;
        int count = 1;
        
        while (count != N)
        {
			num++;
            
			if (Convert.ToString(num).Contains("666"))
            {
				count++;
			}
		}
		Console.WriteLine(num);
    }
}