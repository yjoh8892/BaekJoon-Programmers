import java.util.Scanner;

public class Main {
    public static void main(String[] arsgs) {
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt();
        int[] question = {12, 11, 11, 10, 9, 9, 9, 8, 7, 6, 6};
        int[] penalty = {1600, 894, 1327, 1311, 1004, 1178, 1357, 837, 1055, 556, 773};
        
        System.out.println(question[N - 1] + " " + penalty[N - 1]);
    }
}