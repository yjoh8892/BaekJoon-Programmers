import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int A = sc.nextInt();
        int B = sc.nextInt();
        int C = sc.nextInt();
        int Max;
        
        if(A == B && A == C) {
            System.out.println(10000 + A * 1000);
        } else if(A == B && A != C) {
            System.out.println(1000 + A * 100);
        } else if(A != B && A == C) {
            System.out.println(1000 + A * 100);
        } else if(B == C && B != A) {
            System.out.println(1000 + B * 100);
        } else {
            if(A > B && A > C) {
                Max = A;
            } else if (B > A && B > C) {
                Max = B;
            } else {
                Max = C;
            }
            System.out.println(Max * 100);
        }
    }
}