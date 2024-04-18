using System;

class Q5622
{
    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        int sum = 0;
        
        for (int i = 0; i < S.Length; i++)
        {
            switch (S[i])
            {
                case <= 'C':
                    sum += 3;
                    break;
                    
                case <= 'F':
                    sum += 4;
                    break;
                    
                case <= 'I':
                    sum += 5;
                    break;
                    
                case <= 'L':
                    sum += 6;
                    break;
                        
                case <= 'O':
                    sum += 7;
                    break;
                    
                case <= 'S':
                    sum += 8;
                    break;
                    
                case <= 'V':
                    sum += 9;
                    break;
                        
                case <= 'Z':
                    sum += 10;
                    break;
            }
        }
        
        Console.WriteLine(sum);
    }
}
