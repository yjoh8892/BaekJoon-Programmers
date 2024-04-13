using System;

class Q10951
{
    static void Main(String[] args)
    {
        while (true)
        {
            String input = Console.ReadLine();
            
            if (input == null)
            {
                break;
            }
            
            String[] S = input.Split();
            
            int A = int.Parse(S[0]);
            int B = int.Parse(S[1]);
            
            Console.WriteLine(A + B);
        }
    }        
}