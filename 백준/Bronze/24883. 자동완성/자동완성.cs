using System;

class Q24883
{
    static void Main(string[] args)
    {
        char ch = Char.Parse(Console.ReadLine());
        
        if (ch == 'N' || ch == 'n') {
            Console.WriteLine("Naver D2");
        } else {
            Console.WriteLine("Naver Whale");
        }
    }
}