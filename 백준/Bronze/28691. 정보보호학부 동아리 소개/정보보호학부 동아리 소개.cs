using System;

class Q28691
{
    static void Main(string[] args)
    {
        string S = Console.ReadLine();
        
        if (S.Equals("M"))
        {
            Console.WriteLine("MatKor");
        }
        else if (S.Equals("W"))
        {
            Console.WriteLine("WiCys");
        }
        else if (S.Equals("C"))
        {
            Console.WriteLine("CyKor");
        }
        else if (S.Equals("A"))
        {
            Console.WriteLine("AlKor");
        }
        else if (S.Equals("$"))
        {
            Console.WriteLine("$clear");
        }
    }
}