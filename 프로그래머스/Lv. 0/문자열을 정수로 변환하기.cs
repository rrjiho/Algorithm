using System;

public class Solution {
    public int solution(string n_str) {
        int answer = 0;
        
        answer = Int32.Parse(n_str);
        // 그냥 int로 해도 상관 x, Int32는 .NET 표현법
        return answer;
    }
}
