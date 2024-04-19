using System;

class Q3003
{
    static void Main(string[] args)
    {
        string[] S = Console.ReadLine().Split();
        int King = int.Parse(S[0]);
        int Queen = int.Parse(S[1]);
        int Rook = int.Parse(S[2]);
        int Bishop = int.Parse(S[3]);
        int Knight = int.Parse(S[4]);
        int Pawn = int.Parse(S[5]);
        
        Console.Write((1 - King) + " ");
        Console.Write((1 - Queen) + " ");
        Console.Write((2 - Rook) + " ");
        Console.Write((2 - Bishop) + " ");
        Console.Write((2 - Knight) + " ");
        Console.Write(8 - Pawn);
    }
}
