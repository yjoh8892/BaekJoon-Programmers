import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int A = sc.nextInt();
        int B = sc.nextInt();
        
        if (A > B) {
            System.out.println(B + (B + 1));
        } else {
            System.out.println(A + (A - 1));
        }
    }
}