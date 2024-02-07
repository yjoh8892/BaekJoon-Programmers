import java.util.Scanner;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        char[][] str = new char[5][15];
        
        for (int i = 0; i < str.length; i++) {
            String S = sc.next();
            
            for (int j = 0; j < S.length(); j++) {
                str[i][j] = S.charAt(j);
            }
        }
        
        for (int i = 0; i < 15; i++) {
            for (int j = 0; j < 5; j++) {
                if (str[j][i] == '\0') {
                    continue;
                }
                System.out.print(str[j][i]);
            } 
        }
    }
}