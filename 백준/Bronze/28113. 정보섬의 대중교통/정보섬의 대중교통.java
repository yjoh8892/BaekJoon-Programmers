import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        int A = sc.nextInt();
        int B = sc.nextInt();
        
        if (N <= B && B == A) {
			System.out.println("Anything");
		} else if (N <= B && B - A > 0) {
			System.out.println("Bus");
		} else {
			System.out.println("Subway");
		}
    }
}