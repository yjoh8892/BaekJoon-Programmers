using System;

class Q10798 {
    static void Main(String[] args) {
        char[,] ch = new char[5,15];
        string result = "";
        
        for (int i = 0; i < 5; i++)
        {
            string S = Console.ReadLine();
            
            for (int j = 0; j < S.Length; j++)
            {
                ch[i,j] = S[j];
            }
        }
        
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (ch[j,i] == '\0')
                {
                    continue;
                }
                
                result += ch[j,i];
            } 
        }
        
        Console.Write(result);
    }
}