using System;

class Q10988
{
    static void Main(String[] args)
    {
        String S = Console.ReadLine();
        int count = 0;
        
        for (int i = 0; i < S.Length / 2; i++)
        {
            if (S[i] == S[S.Length - 1 -i])
            {
                count++;
            }
        }
        
        if (count == S.Length / 2)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}