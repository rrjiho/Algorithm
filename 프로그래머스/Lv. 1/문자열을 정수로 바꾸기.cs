using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        answer = Int32.Parse(s);
        // 부호 if(s[0] == '-') 이런 식으로 풀어서도 가능하지만 매우 보편적, 효율적으로 사용하는 방법을 사용했음
        return answer;
    }
}
