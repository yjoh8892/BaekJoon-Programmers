import java.util.*;

public class Main {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        
        String word = sc.next();
        int mid = word.length() / 2;
        int result = 1;
        
        for(int i = 0; i < mid; i++) {
            if(word.charAt(i) != word.charAt(word.length() - i - 1)) {
                result = 0;
            }
        }
        
        System.out.println(result);
    }
}