import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int S = sc.nextInt();
        int K = sc.nextInt();
        int H = sc.nextInt();
        int sum = S + K + H;
        int min = Math.min(S, K);
		min = Math.min(min, H);
        
        if (sum >= 100) {
            System.out.println("OK");
        } else {
            if (min == S) {
                System.out.println("Soongsil");
            } else if (min == K) {
                System.out.println("Korea");
            } else {
                System.out.println("Hanyang");
            }
        }
    }
}