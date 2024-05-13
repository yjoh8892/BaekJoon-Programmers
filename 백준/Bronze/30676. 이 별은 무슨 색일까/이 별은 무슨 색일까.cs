using System;

class Q30676
{
    static void Main(string[] args)
    {
        int lambda = int.Parse(Console.ReadLine());
        
        if (lambda >= 620 && lambda <= 780)
        {
            Console.WriteLine("Red");
        }
        else if (lambda >= 590 && lambda < 620)
        {
            Console.WriteLine("Orange");
        }
        else if (lambda >= 570 && lambda < 590)
        {
            Console.WriteLine("Yellow");
        }
        else if (lambda >= 495 && lambda < 570)
        {
            Console.WriteLine("Green");
        }
        else if (lambda >= 450 && lambda < 495)
        {
            Console.WriteLine("Blue");
        }
        else if (lambda >= 425 && lambda < 450)
        {
            Console.WriteLine("Indigo");
        }
        else
        {
            Console.WriteLine("Violet");
        }
    }
}