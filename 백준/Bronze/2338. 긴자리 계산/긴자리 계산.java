import java.util.Scanner;
import java.math.BigInteger;
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        BigInteger A = sc.nextBigInteger();
        BigInteger B = sc.nextBigInteger();
        BigInteger sum = A.add(B);
        BigInteger sub = A.subtract(B);
        BigInteger mul = A.multiply(B);
        
        System.out.println(sum);
        System.out.println(sub);
        System.out.println(mul);
    }
}