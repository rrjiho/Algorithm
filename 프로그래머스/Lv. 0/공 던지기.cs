using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int idx = (k - 1) * 2;
        
        answer = idx > numbers.Length ? numbers[idx % numbers.Length] : numbers[idx];
        
        return answer;
    }
}
