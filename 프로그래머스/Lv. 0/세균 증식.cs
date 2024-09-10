using System;

public class Solution {
    public int solution(int n, int t) {
        int answer = n;
        
        for (int i = 0; i < t; i++)
            answer *= 2;

        //int answer = n << t; 비트 시프트 사용
        // 수학적으로 n * (2^t)와 같음
        
        return answer;
    }
}
