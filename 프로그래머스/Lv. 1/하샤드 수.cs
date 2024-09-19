public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int sum = 0;
        
        string str = x.ToString();
        foreach (char c in str)
        {
            sum += (c - 48);
        }
        
        if (x % sum == 0)
            answer = true;
        else
            answer = false;

      // 이것도 % / 사용해서 정수만을 이용 해결 가능
        
        return answer;
    }
}
