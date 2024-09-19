using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 45;
        
        answer -= numbers.Sum();
        
        return answer;
    }
}
