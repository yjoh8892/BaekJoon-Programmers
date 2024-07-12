using System;
using System.Globalization;

class Q16170
{
    static void Main(string[] args)
    {
        DateTime currentUtc0Time = DateTime.UtcNow;
        string year = currentUtc0Time.ToString("yyyy");
        string month = currentUtc0Time.ToString("MM");
        string day = currentUtc0Time.ToString("dd");

        Console.WriteLine($"{year}\n{month}\n{day}");
    }
}