using System;

class Q2566
{
    static void Main(string[] args)
    {
        int[,] arr = new int[9,9];
        int Max = 0;
        int row = 0;
        int col = 0;
        
        for (int i = 0; i < 9; i++)
        {
            string[] line = Console.ReadLine().Split();
            
            for (int j = 0; j < 9; j++)
            {
                arr[i,j] = int.Parse(line[j]);
                
                if (Max < arr[i,j])
                {
                    Max = arr[i,j];
                    row = i;
                    col = j;
                }
            }
        }
        
        Console.WriteLine(Max);
        Console.WriteLine((row + 1) + " " + (col + 1));
    }
}