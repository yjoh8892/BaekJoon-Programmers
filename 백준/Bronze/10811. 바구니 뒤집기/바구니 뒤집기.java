import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        int[] arr = new int[N + 1];
        int M = sc.nextInt();
        
        for(int i = 1; i <= N; i++) {
            arr[i] = i;
        }
        
        for(int i = 0; i < M; i++) {
            int A = sc.nextInt();
            int B = sc.nextInt();
            
            while(A < B) {
				int temp = arr[A];
				arr[A++] = arr[B];
				arr[B--] = temp;
			}
        }
        
        for(int i = 1; i <= N; i++) {
            System.out.print(arr[i] + " ");
        }
    }
}