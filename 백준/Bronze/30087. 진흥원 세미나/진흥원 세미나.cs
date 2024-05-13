using System;

class Q30087
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < N; i++)
        {
            String seminar = Console.ReadLine();
            
            if (seminar.Equals("Algorithm"))
            {
                Console.WriteLine(204);
            }
            else if (seminar.Equals("DataAnalysis"))
            {
                Console.WriteLine(207);
            }
            else if (seminar.Equals("ArtificialIntelligence"))
            {
                Console.WriteLine(302);
            }
            else if (seminar.Equals("CyberSecurity"))
            {
                Console.WriteLine("B101");
            }
            else if (seminar.Equals("Network"))
            {
                Console.WriteLine(303);
            }
            else if (seminar.Equals("Startup"))
            {
                Console.WriteLine(501);
            }
            else
            {
                Console.WriteLine(105);
            }
        }
    }
}