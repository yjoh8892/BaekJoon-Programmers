import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        String S = sc.nextLine();
        int N = sc.nextInt();
        char ch = S.charAt(N - 1);
        
        System.out.println(ch);
    }
}