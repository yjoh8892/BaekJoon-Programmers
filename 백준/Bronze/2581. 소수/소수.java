import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int M = sc.nextInt();
        int N = sc.nextInt();
        
        int min = N;
        int sum = 0;
        int[] arr = new int[N + 1];
        
        for (int i = M; i <= N; i++) {
            boolean check = true;
			
            if (i == 1) {
                continue;
            }
            
            for (int j = 2; j < i; j++) {
                if (i % j == 0) {
                    check = false;
					break;
				}
			}
            
            if (check) {
                    arr[i] = i;
                    sum += i;
            }
        }
        
        if (sum == 0) {
            System.out.println(-1);
        } else {
            for (int i = 0; i < N; i++) {
                if (min > arr[i] && arr[i] != 0) {
                    min = arr[i];
                }
            }
            System.out.println(sum);
            System.out.println(min);
        }
    }
}