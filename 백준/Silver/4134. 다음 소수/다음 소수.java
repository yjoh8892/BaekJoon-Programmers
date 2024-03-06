import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int T = sc.nextInt();
        
        for (int i = 0; i < T; i++) {
            long n = sc.nextLong();
            
            while (true) {
                long count = 0;
                for (long j = 2; j <= Math.sqrt(n); j++) {
                    if (n % j == 0) {
                        count++;
                        break;
                    }
                }
                if (count == 0) {
                    if (n == 0 || n == 1) {
                        n = 2;
                    }
                    System.out.println(n);
                    break;
                }
                n++;
            }
        }
    }
}