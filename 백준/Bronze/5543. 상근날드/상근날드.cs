using System;

class Q5543
{
    static void Main(string[] args)
    {
        int burger = 2001;
		int drink = 2001;
        
        for (int i = 0; i < 3; i++) {
			int value = int.Parse(Console.ReadLine());
			if (value < burger) {
				burger = value;
			}
		}
        
        for (int i = 0; i < 2; i++) {
			int value = int.Parse(Console.ReadLine());
			if (value < drink) {
				drink = value;
			}
		}
 
		Console.WriteLine(burger + drink - 50);
    }
}