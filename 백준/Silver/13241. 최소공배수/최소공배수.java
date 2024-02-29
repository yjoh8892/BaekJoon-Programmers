import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        long A = sc.nextLong();
        long B = sc.nextLong();
        long gcd = getGCD(Math.max(A, B), Math.min(A, B));
        
        System.out.println(A * B / gcd);
    }
    
    public static long getGCD(long A, long B) {
        while(B > 0) {
            long tmp = A;
            A = B;
            B = tmp % B;
        }
        return A;
    }
}