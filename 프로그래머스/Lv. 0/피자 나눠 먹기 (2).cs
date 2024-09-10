using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int slice = 6;
        
        while(slice % n != 0)
        {
            slice += 6;
        }
        
        answer = slice / 6;
        
        return answer;
    }
}
