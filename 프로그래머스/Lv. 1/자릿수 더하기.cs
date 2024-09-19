using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        // 1. 문자열 사용
        string str = n.ToString();
        
        foreach (char c in str)
        {
            answer += (c - 48);
        }

        // 2. 정수 사용
        while (n > 0)
        {
            answer += n % 10;
            n /= 10;
        }
        return answer;
    }
}
