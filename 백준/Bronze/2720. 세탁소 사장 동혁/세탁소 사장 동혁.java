import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int T = sc.nextInt();
        int Q = 25;
        int D = 10;
        int N = 5;
        int P = 1;
        
        
        for (int i = 0; i < T; i++) {
            int C = sc.nextInt();
            int QResult = C / Q;
            int DResult = (C % Q) / D;
            int NResult = ((C % Q) % D) / N;
            int PResult = (((C % Q) % D) % N) / P;
            
            System.out.println(QResult + " " + DResult + " " + NResult + " " + PResult);
        }
    }
}