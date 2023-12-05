import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        int K = sc.nextInt();
        int mulN = 1;
        int mulK = 1;
        int mulNK = 1;
        
        for (int i = N; i >= 1; i--) {
            mulN *= i;
        }
        
        for (int i = K; i >= 1; i--) {
            mulK *= i;
        }
        
        for (int i = N - K; i >= 1; i--) {
            mulNK *= i;
        }
        
        System.out.println(mulN / (mulK * mulNK));
    }
}