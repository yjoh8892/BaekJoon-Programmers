using System;

class Q31994
{
    static void Main(string[] args)
    {
        String maxseminar = "";
        int max = 0;
        
        for (int i = 0; i < 7; i++)
        {
            string[] S = Console.ReadLine().Split(); 
            string seminar = S[0];
            int num = int.Parse(S[1]);
            
            if (num > max) {
                maxseminar = seminar;
                max = num;
            }
        }
        
        Console.WriteLine(maxseminar);
    }
}