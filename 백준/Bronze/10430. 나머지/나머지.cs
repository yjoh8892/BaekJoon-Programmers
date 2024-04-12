using System;

class Q10430
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        int C = int.Parse(S[2]);
        
        Console.WriteLine((A + B) % C);
        Console.WriteLine(((A % C) + (B % C)) % C);
        Console.WriteLine((A * B) % C);
        Console.WriteLine(((A % C) * (B % C)) % C);
    }
}