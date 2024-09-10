using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        string s = n.ToString();
        
        foreach (char c in s)
            answer += (int)c - 48;

      
        // while 통해서 n % 10, n / 10 으로 구하는 방법도 가능
        return answer;
    }
}
