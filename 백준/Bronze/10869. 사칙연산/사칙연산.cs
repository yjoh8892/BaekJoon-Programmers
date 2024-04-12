using System;

class Q10869
{
    static void Main(String[] args)
    {
        String[] S = Console.ReadLine().Split();
        
        int A = int.Parse(S[0]);
        int B = int.Parse(S[1]);
        
        Console.WriteLine(A + B);
        Console.WriteLine(A - B);
        Console.WriteLine(A * B);
        Console.WriteLine(A / B);
        Console.WriteLine(A % B);
    }
}