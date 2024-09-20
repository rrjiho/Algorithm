public class Solution {
    public int[] solution(int n, int m) {           
        int min = gcd(n, m);
        int max = n * m / min;
        
        int[] answer = new int[] {min, max};

        return answer;
    }
    
    public int gcd(int a, int b)
    {
        return (a % b == 0 ? b : gcd(b, a % b));
    }
}
