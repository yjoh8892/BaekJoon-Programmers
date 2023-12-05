import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int King = sc.nextInt();
        int Queen = sc.nextInt();
        int Rook = sc.nextInt();
        int Bishop = sc.nextInt();
        int Knight = sc.nextInt();
        int Pawn = sc.nextInt();
        
        System.out.println(1 - King);
        System.out.println(1 - Queen);
        System.out.println(2 - Rook);
        System.out.println(2 - Bishop);
        System.out.println(2 - Knight);
        System.out.println(8 - Pawn);
    }
}