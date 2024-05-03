using System;

class Q1735
{
    static void Main(string[] args)
    {
        string[] S1 = Console.ReadLine().Split();
        string[] S2 = Console.ReadLine().Split();
        int numeratorS1 = int.Parse(S1[0]);
        int numeratorS2 = int.Parse(S2[0]);
        int denominatorS1 = int.Parse(S1[1]);
        int denominatorS2 = int.Parse(S2[1]);
        
        int numerator = numeratorS1 * denominatorS2 + numeratorS2 * denominatorS1;
        int denominator = denominatorS1 * denominatorS2;
        int GCD = getGCD(numerator, denominator);
        
        numerator /= GCD;
        denominator /= GCD;
        
        Console.WriteLine(numerator + " " + denominator);
    }
    
    public static int getGCD(int A, int B)
    {
        while (B > 0)
        {
            int tmp = A;
            A = B;
            B = tmp % B;
        }
        
        return A;
    }
}