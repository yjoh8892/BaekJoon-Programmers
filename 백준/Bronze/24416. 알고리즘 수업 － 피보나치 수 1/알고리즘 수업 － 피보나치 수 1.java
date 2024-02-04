import java.util.Scanner;
import java.io.IOException;

public class Main {
    static int count1 = 0;
    static int count2 = 0;
    static int[] f;
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt();
        f = new int[n];
        
        fib(n);
        fibonacci(n);
        
        System.out.println(count1);
        System.out.println(count2);
    }
    
    public static int fib(int n) {
        if (n == 1 || n == 2) {
            count1++;
            return 1;
        }
        return (fib(n - 1) + fib(n - 2));
    }
    
    public static int fibonacci(int n) {
        f[0] = 1;
        f[1] = 1;
        
        for (int i = 2; i < n; i++) {
            count2++;
            f[i] = f[i - 1] + f[i - 2];
        }
        return f[n - 1];
    }
}