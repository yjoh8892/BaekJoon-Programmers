import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int K = sc.nextInt();
        int N = sc.nextInt();
        int M = sc.nextInt();
        int sum = K * N;
        
        if (M < sum) {
            System.out.println(sum - M);
        } else {
            System.out.println(0);
        }
    }
}