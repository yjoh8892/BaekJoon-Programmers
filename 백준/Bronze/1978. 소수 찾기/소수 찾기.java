import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        int count = 0;
        
        for(int i = 0; i < N; i++) {
            boolean isPrime = true;
            int A = sc.nextInt();
            
            if(A == 1) {
                continue;
            }
            
            for(int j = 2; j <= Math.sqrt(A); j++) {
				if(A % j == 0) {
					isPrime = false;
				}
            }
            
            if(isPrime) {
                count++;
            }
        }
        System.out.println(count);
    }
}