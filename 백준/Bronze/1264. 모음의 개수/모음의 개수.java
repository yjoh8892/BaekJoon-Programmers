import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        while (true) {
            String S = sc.nextLine().toLowerCase();
            int count = 0;
            
            if (S.equals("#")) {
                break;
            }
            
            for (int i = 0; i < S.length(); i++) {
                if (S.charAt(i) == 'a' || S.charAt(i) == 'e' || S.charAt(i) == 'i' || S.charAt(i) == 'o' || S.charAt(i) == 'u') {
                    count++;
                }
            }
            
            System.out.println(count);
        }
    }
}