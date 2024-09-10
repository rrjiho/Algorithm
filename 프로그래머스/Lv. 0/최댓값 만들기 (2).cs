using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int m_index = numbers.Length - 1;
        
        Array.Sort(numbers);
        if(numbers[0] * numbers[1] > numbers[m_index - 1] * numbers[m_index])
            answer = numbers[0] * numbers[1];
        else
            answer = numbers[m_index - 1] * numbers[m_index];
        
        return answer;
    }
}
