using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        double temp = 0;
        
        temp = (double)num1 / (double)num2 * 1000;
        answer = (int)temp;
        
        return answer;
    }
}
