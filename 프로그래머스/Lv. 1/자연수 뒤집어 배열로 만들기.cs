public class Solution {
    public int[] solution(long n) {
        string s = n.ToString();
        int[] answer = new int[s.Length];
        
        for (int i = 0; i < s.Length; i++)
        {
            answer[i] = (int) (n % 10);
            n /= 10;
        }
        
        return answer;
    }
}
