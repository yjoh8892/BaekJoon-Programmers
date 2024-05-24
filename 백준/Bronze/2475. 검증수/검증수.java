import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int A = sc.nextInt();
        int B = sc.nextInt();
        int C = sc.nextInt();
        int D = sc.nextInt();
        int E = sc.nextInt();
        int sum = A * A + B * B + C * C + D * D + E * E;
        int result = sum % 10;
        
        System.out.println(result);
    }
}