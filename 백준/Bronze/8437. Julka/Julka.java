import java.util.Scanner;
import java.math.BigInteger;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        BigInteger Q = sc.nextBigInteger();
		BigInteger D = sc.nextBigInteger();
		BigInteger K = Q.add(D).divide(BigInteger.valueOf(2));
		BigInteger N = Q.subtract(D).divide(BigInteger.valueOf(2));

        System.out.println(K);
        System.out.println(N);
    }
}