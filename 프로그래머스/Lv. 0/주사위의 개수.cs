using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 0;
        
        int row = box[0];
        int column = box[1];
        int height = box[2];
        
        answer = (row / n)*(column / n)*(height / n);
        
        return answer;
    }
}
