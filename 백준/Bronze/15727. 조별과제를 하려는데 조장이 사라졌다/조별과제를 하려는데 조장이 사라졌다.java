import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int t = sc.nextInt();
        int count = 0;
        
        while (t > 0) {
            t -= 5;
            count++;
        }
        
        System.out.println(count);
    }
}