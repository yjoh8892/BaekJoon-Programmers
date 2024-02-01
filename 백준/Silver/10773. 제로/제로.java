import java.util.Scanner;
import java.util.Stack;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int K = sc.nextInt();
        int sum = 0;
        Stack<Integer> stack = new Stack<Integer>();
        
        for (int i = 0; i < K; i++) {
            int num = sc.nextInt();
            
            if (num == 0) {
                stack.pop();
            } else {
                stack.add(num);
            }
        }
        
        for (int o : stack) {
            sum += o;
        }
        
        System.out.println(sum);
    }
}