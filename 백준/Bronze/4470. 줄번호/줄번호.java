import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        String[] S = new String[N];
        S[0] = sc.nextLine();
        
        for (int i = 0; i < N; i++) {
            S[i] = sc.nextLine();
        }
        
        for (int i = 0; i < N; i++) {
            System.out.printf("%d. ", i + 1);
            System.out.println(S[i]);
        }
    }
}