import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        int M = sc.nextInt();
        int[] arr = new int[M];
        int result = 0;
        
        for (int i = 0; i < N; i++) {
            arr[i] = sc.nextInt();
        }
        
        for (int i = 0; i < N; i++) {
            for (int j = i + 1; j < N; j++) {
                for (int k = j + 1; k < N; k++) {
                    int sum = arr[i] + arr[j] + arr[k];

                    if (result < sum && sum <= M) {
                        result = sum;
                    }
                }
            }
        }
        System.out.println(result);
    }
}