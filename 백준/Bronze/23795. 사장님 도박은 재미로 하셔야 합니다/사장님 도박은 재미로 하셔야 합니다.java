import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int sum = 0;
        while (true) {
            int A = sc.nextInt();
            
            if (A == -1){
                break;
            }
            
            sum += A;
        }
        
        System.out.println(sum);
    }
}