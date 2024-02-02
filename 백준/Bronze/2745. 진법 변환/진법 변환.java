import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        String N = sc.next();
        int B = sc.nextInt();

        int answer = 0;
        int tmp = 1;
        
        for (int i = N.length() - 1; i >= 0; i--) {
            char C = N.charAt(i);
            if ('A' <= C && C <= 'Z') {
                answer += (C - 'A' + 10) * tmp;
            } else {
                answer += (C - '0') * tmp;
            }
            tmp *= B;
        }
        System.out.println(answer);
    }
}